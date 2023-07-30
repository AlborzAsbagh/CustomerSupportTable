#nullable enable
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Dynamic;
using Microsoft.IdentityModel.Tokens;
using OrjinDestek.Models;
using OrjinDestek.Services.TokenService;
using OrjinDestek.Services.TokenValidationService;


namespace OrjinDestek.Controllers;

public class CustomerDetailController : Controller
{
	private readonly SqlConnection _con;
	private readonly SqlConnection _conToPm;
	private SqlCommand _cmd = null!;
	private SqlDataReader _rd = null!;
	private string? _query;
	private string? _variable;
	private readonly IToken _token;
	private readonly ITokenValidate _tokenValidate;

	public CustomerDetailController(IConfiguration configuration, IToken token, ITokenValidate tokenValidate)
	{
		_con = new SqlConnection(configuration.GetConnectionString("Default"));
		_conToPm = new SqlConnection(configuration.GetConnectionString("Orjinpm"));
		_token = token;
		_tokenValidate = tokenValidate;
	}


	// GET
	public IActionResult Index(string? token , int? musteriId)
	{
		if (!token.IsNullOrEmpty() && token!.Equals(_token.GetToken()) && _tokenValidate.IsTokenValid(token))
		{
			dynamic dy = new ExpandoObject();
			dy.token = token;
			dy.getCustomerInfo = getCustomerInfo(musteriId);
			return View(dy);

		}
		return RedirectToAction("Index", "Login");
	}


	//Get Customer Info
	[HttpGet]
	public TbMusteriBilgileri getCustomerInfo(int? musteriId)
	{
		_query = $" select * from ORJINCRM.dbo.TB_MUSTERI_BILGILERI where TB_MB_ID = {musteriId} ";
		TbMusteriBilgileri? entity = new TbMusteriBilgileri();

		try
		{
			_cmd = new SqlCommand(_query, _con);
			_con.Open();
			_rd = _cmd.ExecuteReader();
			if(_rd != null)
			{
				while (_rd.Read())
				{
					entity.MusteriId = Convert.ToInt32(_rd["TB_MB_ID"]);
					entity.FirmaAdi = (string?)(_rd["TB_MB_FIRMA_ISMI"] != DBNull.Value ? _rd["TB_MB_FIRMA_ISMI"] : "");
					entity.IpAdres = (string?)(_rd["TB_MB_IP_ADRESI"] != DBNull.Value ? _rd["TB_MB_IP_ADRESI"] : "");
					entity.KullaniciKodu = (string?)(_rd["TB_MB_KULLANICI_KODU"] != DBNull.Value ? _rd["TB_MB_KULLANICI_KODU"] : "");
					entity.Parola = (string?)(_rd["TB_MB_PAROLA"] != DBNull.Value ? _rd["TB_MB_PAROLA"] : "");
					entity.SqlSunucu = (string?)(_rd["TB_MB_SQL_SUNUCU"] != DBNull.Value ? _rd["TB_MB_SQL_SUNUCU"] : "");
					entity.SqlKullanici = (string?)(_rd["TB_MB_SQL_KULLANICI"] != DBNull.Value ? _rd["TB_MB_SQL_KULLANICI"] : "");
					entity.SqlSifre = (string?)(_rd["TB_MB_SQL_SIFRE"] != DBNull.Value ? _rd["TB_MB_SQL_SIFRE"] : "");
					entity.AnyDeskId = (string?)(_rd["TB_MB_ANY_DESK_ID"] != DBNull.Value ? _rd["TB_MB_ANY_DESK_ID"] : "");
					entity.AnyDeskSifre = (string?)(_rd["TB_MB_ANY_SIFRE"] != DBNull.Value ? _rd["TB_MB_ANY_SIFRE"] : "");
					entity.TeamViewer = (string?)(_rd["TB_MB_TEAM_VIEWER"] != DBNull.Value ? _rd["TB_MB_TEAM_VIEWER"] : "");
					entity.TeamViewerSifre = (string?)(_rd["TB_MB_TEAM_SIFRE"] != DBNull.Value ? _rd["TB_MB_TEAM_SIFRE"] : "");
					entity.VpnKullanici = (string?)(_rd["TB_MB_VPN_KULLANICI"] != DBNull.Value ? _rd["TB_MB_VPN_KULLANICI"] : "");
					entity.VpnSifre = (string?)(_rd["TB_MB_VPN_SIFRE"] != DBNull.Value ? _rd["TB_MB_VPN_SIFRE"] : "");
					entity.YardimMasasi = (string?)(_rd["TB_MB_YARDIM_MASASI"] != DBNull.Value ? _rd["TB_MB_YARDIM_MASASI"] : "");
					entity.Aciklama = (string?)(_rd["TB_MB_ACIKLAMA"] != DBNull.Value ? _rd["TB_MB_ACIKLAMA"] : "");
				}
			}
			_con.Close();
			return entity;
		} catch(Exception e)
		{
			_con.Close();
			TempData["Failure"] = e.Message;
			return entity;
		}
	}

	//Update The Record
	[HttpPost]
	public IActionResult UpdateRecord(TbMusteriBilgileri musteri)
	{
		try
		{
			_query = " update ORJINCRM.dbo.TB_MUSTERI_BILGILERI set ";
			_query += $" TB_MB_FIRMA_ISMI = '{musteri.FirmaAdi}' , ";
			_query += $" TB_MB_IP_ADRESI = '{musteri.IpAdres}' , ";
			_query += $" TB_MB_KULLANICI_KODU = '{musteri.KullaniciKodu}' , ";
			_query += $" TB_MB_PAROLA =  '{musteri.Parola}' , ";
			_query += $" TB_MB_SQL_SUNUCU = '{musteri.SqlSunucu}' , ";
			_query += $" TB_MB_SQL_KULLANICI = '{musteri.SqlKullanici}' , ";
			_query += $" TB_MB_SQL_SIFRE = '{musteri.SqlSifre}', ";
			_query += $" TB_MB_ANY_DESK_ID = '{musteri.AnyDeskId}', ";
			_query += $" TB_MB_ANY_SIFRE = '{musteri.AnyDeskSifre}' , ";
			_query += $" TB_MB_TEAM_VIEWER = '{musteri.TeamViewer}' , ";
			_query += $" TB_MB_TEAM_SIFRE =  '{musteri.TeamViewerSifre}' , ";
			_query += $" TB_MB_VPN_KULLANICI = '{musteri.VpnKullanici}' , ";
			_query += $" TB_MB_VPN_SIFRE = '{musteri.VpnSifre}' , ";
			_query += $" TB_MB_YARDIM_MASASI = '{musteri.YardimMasasi}' , ";
			_query += $" TB_MB_ACIKLAMA = '{musteri.Aciklama}'  ";
			_query += $" where TB_MB_ID = {musteri.MusteriId} ";

			using (SqlCommand _cmd = new SqlCommand(_query, _con))
			{
				_con.Open();
				_cmd.ExecuteNonQuery();
				_con.Close();
			}
			TempData["Success"] = "Kayıt başarılı şekilde güncellendi";
			return RedirectToAction("Index", "ClientInfo", new { token = _token.GetToken() });
		}
		catch (Exception ex)
		{
			_con.Close();
			TempData["Failure"] = ex.Message;
			return RedirectToAction("Index", "ClientInfo", new { token = _token.GetToken() });
		}


	}
}