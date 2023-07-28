#nullable enable
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Dynamic;
using Microsoft.IdentityModel.Tokens;
using OrjinDestek.Models;
using OrjinDestek.Services.TokenService;
using OrjinDestek.Services.TokenValidationService;


namespace OrjinDestek.Controllers;

public class AddCustomerController : Controller
{
	private readonly SqlConnection _con;
	private readonly SqlConnection _conToPm;
	private SqlCommand _cmd = null!;
	private SqlDataReader _rd = null!;
	private string? _query;
	private string? _variable;
	private readonly IToken _token;
	private readonly ITokenValidate _tokenValidate;

	public AddCustomerController(IConfiguration configuration, IToken token, ITokenValidate tokenValidate)
	{
		_con = new SqlConnection(configuration.GetConnectionString("Default"));
		_conToPm = new SqlConnection(configuration.GetConnectionString("Orjinpm"));
		_token = token;
		_tokenValidate = tokenValidate;
	}


	// GET
	public IActionResult Index(string? token)
	{
		if (!token.IsNullOrEmpty() && token!.Equals(_token.GetToken()) && _tokenValidate.IsTokenValid(token))
		{
			dynamic dy = new ExpandoObject();
			dy.token = token;
			return View(dy);

		}
		return RedirectToAction("Index", "Login");
	}


	//ADD NEW RECORD
	[HttpPost]
	public IActionResult AddNewRecord(TbMusteriBilgileri musteri)
	{
		try
		{
			_query = @" insert into ORJINCRM.dbo.TB_MUSTERI_BILGILERI 
					( TB_MB_FIRMA_ISMI 
					,TB_MB_IP_ADRESI 
					, TB_MB_KULLANICI_KODU 
					, TB_MB_PAROLA 
					,TB_MB_SQL_SUNUCU 
					,TB_MB_SQL_KULLANICI 
					,TB_MB_SQL_SIFRE 
					,TB_MB_ANY_DESK_ID 
					, TB_MB_ANY_SIFRE
					, TB_MB_TEAM_VIEWER
					, TB_MB_TEAM_SIFRE
					,TB_MB_VPN_KULLANICI 
					, TB_MB_VPN_SIFRE
					, TB_MB_YARDIM_MASASI 
					, TB_MB_ACIKLAMA ) values ";

			_query += $" ('{musteri.FirmaAdi}','{musteri.IpAdres}','{musteri.KullaniciKodu}','{musteri.Parola}' , " +
				$" '{musteri.SqlSunucu}','{musteri.SqlKullanici}','{musteri.SqlSifre}','{musteri.AnyDeskId}' , " +
				$" '{musteri.AnyDeskSifre}','{musteri.TeamViewer}','{musteri.TeamViewerSifre}' , " +
				$" '{musteri.VpnKullanici}','{musteri.VpnSifre}','{musteri.YardimMasasi}','{musteri.Aciklama}') ";

			using (SqlCommand _cmd = new SqlCommand(_query, _con))
			{
				_con.Open();
				_cmd.ExecuteNonQuery();
				_con.Close();
			}
			TempData["Success"] = "Kayıt başarılı şekilde eklendi";
			return RedirectToAction("Index", "ClientInfo", new { token = _token.GetToken() });
		} catch (Exception ex)
		{
			_con.Close();
			TempData["Failure"] = ex.Message;
			return RedirectToAction("Index", "ClientInfo", new { token = _token.GetToken() });
		}

	
	}
}