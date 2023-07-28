#nullable enable
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using OrjinDestek.Models;
using OrjinDestek.Services.TokenService;
using OrjinDestek.Services.TokenValidationService;
using OrjinDestek.Services.UserService;

namespace OrjinDestek.Controllers;

public class ClientInfoController : Controller
{

	private SqlConnection _con;
	private SqlCommand _cmd = null!;
	private readonly IUsuerService _userService;
	private readonly IToken _token;
	private readonly ITokenValidate _tokenValidate;
	public ClientInfoController(IConfiguration configuration, IUsuerService userService, IToken token, ITokenValidate tokenValidate)
	{
		_token = token;
		_tokenValidate = tokenValidate;
		_con = new SqlConnection(configuration.GetConnectionString("Default"));
		_userService = userService;
	}
	public IActionResult Index(string? token)
	{
		if (!token.IsNullOrEmpty() && token!.Equals(_token.GetToken()) && _tokenValidate.IsTokenValid(token))
		{
			dynamic dy = new ExpandoObject();
			dy.getList = GetTable(token);
			dy.user = _userService.Getuser();
			dy.token = token;
			return View(dy);
		}

		return RedirectToAction("Index", "Login");

	}

	public List<TbMusteriBilgileri> GetTable(string? token)
	{
		if (!token.IsNullOrEmpty() && token!.Equals(_token.GetToken()))
		{
			_con.Open();
			string query = @"SELECT * FROM [ORJINCRM].[dbo].[TB_MUSTERI_BILGILERI]";
			List<TbMusteriBilgileri> tabloList = new List<TbMusteriBilgileri>();
			try
			{
				_cmd = new SqlCommand(query, _con);
				SqlDataReader dr = _cmd.ExecuteReader();
				if (dr != null)
				{

					while (dr.Read())
					{
						TbMusteriBilgileri musteriTabloModel = new TbMusteriBilgileri();
						musteriTabloModel.MusteriId = Convert.ToInt32(dr["TB_MB_ID"]);
						musteriTabloModel.FirmaAdi = dr["TB_MB_FIRMA_ISMI"] != DBNull.Value ? dr["TB_MB_FIRMA_ISMI"].ToString() : "";
						musteriTabloModel.IpAdres = dr["TB_MB_IP_ADRESI"] != DBNull.Value ? dr["TB_MB_IP_ADRESI"].ToString() : "";
						musteriTabloModel.KullaniciKodu = dr["TB_MB_KULLANICI_KODU"] != DBNull.Value ? dr["TB_MB_KULLANICI_KODU"].ToString() : "";
						musteriTabloModel.Parola = dr["TB_MB_PAROLA"] != DBNull.Value ? dr["TB_MB_PAROLA"].ToString() : "";
						musteriTabloModel.SqlSunucu = dr["TB_MB_SQL_SUNUCU"] != DBNull.Value ? dr["TB_MB_SQL_SUNUCU"].ToString() : "";
						musteriTabloModel.SqlKullanici = dr["TB_MB_SQL_KULLANICI"] != DBNull.Value ? dr["TB_MB_SQL_KULLANICI"].ToString() : "";
						musteriTabloModel.SqlSifre = dr["TB_MB_SQL_SIFRE"] != DBNull.Value ? dr["TB_MB_SQL_SIFRE"].ToString() : "";
						musteriTabloModel.AnyDeskId = dr["TB_MB_ANY_DESK_ID"] != DBNull.Value ? dr["TB_MB_ANY_DESK_ID"].ToString() : "";
						musteriTabloModel.AnyDeskSifre = dr["TB_MB_ANY_SIFRE"] != DBNull.Value ? dr["TB_MB_ANY_SIFRE"].ToString() : "";
						musteriTabloModel.TeamViewer = dr["TB_MB_TEAM_VIEWER"] != DBNull.Value ? dr["TB_MB_TEAM_VIEWER"].ToString() : "";
						musteriTabloModel.TeamViewerSifre = dr["TB_MB_TEAM_SIFRE"] != DBNull.Value ? dr["TB_MB_TEAM_SIFRE"].ToString() : "";
						musteriTabloModel.VpnKullanici = dr["TB_MB_VPN_KULLANICI"] != DBNull.Value ? dr["TB_MB_VPN_KULLANICI"].ToString() : "";
						musteriTabloModel.VpnSifre = dr["TB_MB_VPN_SIFRE"] != DBNull.Value ? dr["TB_MB_VPN_SIFRE"].ToString() : "";
						musteriTabloModel.YardimMasasi = dr["TB_MB_YARDIM_MASASI"] != DBNull.Value ? dr["TB_MB_YARDIM_MASASI"].ToString() : "";

						tabloList.Add(musteriTabloModel);
					}
				}

				_con.Close();
				return tabloList;
			}
			catch (Exception e)
			{
				TempData["Failure"] = e.Message;
				_con.Close();
				return tabloList;
			}
		}
		return null!;
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}

}