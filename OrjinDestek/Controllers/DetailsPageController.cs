#nullable enable
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using OrjinDestek.Models;
using System.Dynamic;
using Microsoft.IdentityModel.Tokens;
using OrjinDestek.Services.TokenService;
using OrjinDestek.Services.TokenValidationService;
using OrjinDestek.Services.UserService;
using FluentEmail.Core;
using FluentEmail.Smtp;

namespace OrjinDestek.Controllers;

public class DetailsPageController : Controller
{
	private SqlConnection _con;
	private SqlConnection _conToPm;
	private SqlCommand _cmd = null!;
	private string? _query;
	private SqlDataReader _rd = null!;
	private string? _variable;
	private readonly IUsuerService _userService;
	private readonly IToken _token;
	private readonly ITokenValidate _tokenValidate;

	public DetailsPageController(IConfiguration configuration, IUsuerService userService, IToken token, ITokenValidate tokenValidate)
	{
		_con = new SqlConnection(configuration.GetConnectionString("Default"));
		_conToPm = new SqlConnection(configuration.GetConnectionString("Orjinpm"));
		_userService = userService;
		_token = token;
		_tokenValidate = tokenValidate;
	}

	// GET
	public IActionResult Index(int refNo, string firmaAdi, string token, int dskRevId)
	{
		if (!token.IsNullOrEmpty() && token.Equals(_token.GetToken()) && _tokenValidate.IsTokenValid(token))
		{
			dynamic dy = new ExpandoObject();
			dy.getRecord = GetRecordDetail(refNo, dskRevId);
			dy.getActions = GetCompletedActions(refNo);
			dy.getActionsNumber = GetActionsNumber(refNo);
			dy.getProjeler = GetProjeler();
			dy.getDestekTipleri = GetDestekTipiListe();
			dy.getDestekPersonel = GetDestekPersonelList();
			dy.getDurumListe = GetDurumListe();
			dy.getDestekKonusu = GetDestekKonusuListe();
			dy.getDestekSekli = GetDestekSekliList();
			dy.user = _userService.Getuser();
			dy.getPersonelEmails = GetPersonelEmails(firmaAdi);
			dy.getGorusulenKisiListe = GetGorusulenKisilerListe(firmaAdi);
			dy.token = token;
			return View(dy);
		}

		return RedirectToAction("Index", "Login");
	}


	//GET RECORD DETAIL
	public DestekTabloModel GetRecordDetail(int refNo, int dskRevId)
	{
		_con.Open();
		string query = $"select TANIM from TB_REVIZYON WHERE TB_REVIZYON_ID = {dskRevId}";
		string? rvzTanim = "";
		if (dskRevId != 0)
		{
			_conToPm.Open();
			_cmd = new SqlCommand(query, _conToPm);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					rvzTanim = _rd["TANIM"] != DBNull.Value ? _rd["TANIM"].ToString() : "";
				}
			}
			_conToPm.Close();
		}
		query = @"SELECT
        D.TB_DESTEK_ID as RefNo
            ,case
        WHEN [DSK_KAPALI]=1 then 'KAPALI'
        WHEN [DSK_KAPALI]=0 then 'AÇIK'
        ELSE NULL
        end AS DURUM
        ,case
                WHEN [DSK_ONCELIK_ID]=1 then 'NORMAL'
                WHEN [DSK_ONCELIK_ID]=2 then 'ACİL'
                WHEN [DSK_ONCELIK_ID]=3 then 'ÇOK ACİL'
                ELSE NULL
                end AS ONCELIK
            , [DSK_BASLAMA_TARIHI] As Tarih
            ,C.CARI_UNVAN as Firma
            ,P.TANIM as Proje
            ,[DSK_KONU_BASLIK] as Konu
            ,CP.CPS_ISIM as TalepEden
            ,K3.DEGER AS DestekTipi
			,K2.DEGER AS DestekSekli
            ,CU3.USER_NAME AS DestekPersonel
            ,DSK_EPOSTA as Email
            ,DSK_TELEFON as TelNo
            ,DSK_ISTEKLER as Aciklama
			,dbo.UDF_BEKLEME_SURESI_HESAP(TB_DESTEK_ID) AS GecenSure
        
        FROM [ORJINCRM].[dbo].[TB_DESTEK] D
            LEFT OUTER JOIN TB_KOD K ON (D.DSK_SONUC_ID=K.TB_KOD_ID)
        LEFT OUTER JOIN TB_PROGRAM P ON(D.DSK_PROGRAM_ID=P.TB_PROGRAM_ID)
        LEFT OUTER JOIN TB_CARI C ON (D.DSK_FIRMA_ID=C.TB_CARI_ID)
        LEFT OUTER JOIN TB_CARI_PERSONEL CP ON (CP.TB_CARI_PERSONEL_ID=D.DSK_GORUSULEN_KISI_ID)
        LEFT OUTER JOIN [TB_CRM_USER] CU1 ON (CU1.TB_CRM_USER_ID=D.DSK_OLUSTURAN_ID)
        LEFT OUTER JOIN [TB_CRM_USER] CU2 ON (CU2.TB_CRM_USER_ID=D.DSK_DEGISTIREN_ID)
        LEFT OUTER JOIN [TB_CRM_USER] CU3 ON (CU3.TB_CRM_USER_ID=D.DSK_PERSONEL_ID)
        LEFT OUTER JOIN TB_KOD K1 ON(K1.TB_KOD_ID=DSK_SONUC_ID)
        LEFT OUTER JOIN TB_KOD K2 ON(K2.TB_KOD_ID=DSK_DESTEK_TIPI_ID)
        LEFT OUTER JOIN TB_KOD K3 ON(K3.TB_KOD_ID=DSK_TALEP_SEBEP_ID) ";

		query += $" WHERE DSK_BASLAMA_TARIHI>'2022-01-01 00:00:00.000' AND TB_DESTEK_ID = {refNo} ORDER BY DSK_KAPALI ASC, DSK_BASLAMA_TARIHI DESC ";
		DestekTabloModel destekTabloModel = new DestekTabloModel();
		try
		{
			_cmd = new SqlCommand(query, _con);
			SqlDataReader dr = _cmd.ExecuteReader();
			if (dr != null)
			{

				while (dr.Read())
				{
					destekTabloModel.RefNo = Convert.ToInt32(dr["RefNo"]);
					destekTabloModel.Durum = dr["Durum"] != DBNull.Value ? dr["Durum"].ToString() : "";
					destekTabloModel.Tarih = dr["Tarih"] != DBNull.Value ? dr["Tarih"].ToString() : "";
					destekTabloModel.Firma = dr["Firma"] != DBNull.Value ? dr["Firma"].ToString() : "";
					destekTabloModel.Proje = dr["Proje"] != DBNull.Value ? dr["Proje"].ToString() : "";
					destekTabloModel.Konu = dr["Konu"] != DBNull.Value ? dr["Konu"].ToString() : "";
					destekTabloModel.TalepEden = dr["TalepEden"] != DBNull.Value ? dr["TalepEden"].ToString() : "";
					destekTabloModel.DestekPersonel = dr["DestekPersonel"] != DBNull.Value ? dr["DestekPersonel"].ToString() : "";
					destekTabloModel.GecenSure = dr["GecenSure"] != DBNull.Value ? dr["GecenSure"].ToString() : "";
					destekTabloModel.EmailHesabi = dr["Email"] != DBNull.Value ? dr["Email"].ToString() : "";
					destekTabloModel.TelNo = dr["TelNo"] != DBNull.Value ? dr["TelNo"].ToString() : "";
					destekTabloModel.Aciklama = dr["Aciklama"] != DBNull.Value ? dr["Aciklama"].ToString() : "";
					destekTabloModel.Oncelik = dr["ONCELIK"] != DBNull.Value ? dr["ONCELIK"].ToString() : "";
					destekTabloModel.DestekTipi = dr["DestekTipi"] != DBNull.Value ? dr["DestekTipi"].ToString() : "";
					destekTabloModel.DestekSekli = dr["DestekSekli"] != DBNull.Value ? dr["DestekSekli"].ToString() : "";
					destekTabloModel.RevizyonBilgisi = rvzTanim;

				}
			}

			_con.Close();
			return (destekTabloModel);
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			return (new DestekTabloModel());
		}
	}

	//GET PROJELER
	public List<String> GetProjeler()
	{
		List<String> projeler = new List<string>();
		try
		{
			_con.Open();
			_query = @"select TB_PROGRAM.TANIM from TB_PROGRAM";
			_cmd = new SqlCommand(_query, _con);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					_variable = _rd["TANIM"] != DBNull.Value ? _rd["TANIM"].ToString() : "";
					projeler.Add(_variable!);
				}
			}

			_con.Close();
			return projeler;
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			projeler.Clear();
			return projeler;
		}
	}

	//GET DESTEK TIPI LIST
	public List<String> GetDestekTipiListe()
	{
		List<String> destekTipleri = new List<string>();
		try
		{
			_con.Open();
			_query = @"SELECT DEGER FROM TB_KOD where KOD=129";
			_cmd = new SqlCommand(_query, _con);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					_variable = _rd["DEGER"] != DBNull.Value ? _rd["DEGER"].ToString() : "";
					destekTipleri.Add(_variable!);
				}
			}

			_con.Close();
			return destekTipleri;
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			return destekTipleri;
		}
	}

	//GET DESTEK PERSONEL LIST
	public List<String> GetDestekPersonelList()
	{
		List<String> destekPersonelListe = new List<string>();
		try
		{
			_con.Open();
			_query = @"SELECT USER_NAME FROM TB_CRM_USER WHERE AKTIF=1";
			_cmd = new SqlCommand(_query, _con);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					_variable = _rd["USER_NAME"] != DBNull.Value ? _rd["USER_NAME"].ToString() : "";
					destekPersonelListe.Add(_variable!);
				}
			}

			_con.Close();
			return destekPersonelListe;
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			return destekPersonelListe;
		}
	}

	//GET DURUM LIST
	public List<String> GetDurumListe()
	{
		List<String> durumListe = new List<string>();
		try
		{
			_con.Open();
			_query = "SELECT DEGER FROM TB_KOD where KOD=124";
			_cmd = new SqlCommand(_query, _con);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					_variable = _rd["DEGER"] != DBNull.Value ? _rd["DEGER"].ToString() : "";
					durumListe.Add(_variable!);
				}
			}
			_con.Close();
			return durumListe;
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			return durumListe;
		}
	}

	//GET GORUSULEN KISILER LIST
	public List<String> GetGorusulenKisilerListe(string? firmaAdi)
	{
		List<String> gorusulenKisilerListe = new List<string>();
		if (!firmaAdi.IsNullOrEmpty())
		{
			try
			{
				_con.Open();
				_query = $"select CPS_ISIM from TB_CARI_PERSONEL CPS  LEFT JOIN TB_CARI TC on CPS.CPS_CARI_ID = TC.TB_CARI_ID where CARI_UNVAN = '{firmaAdi}'";
				_cmd = new SqlCommand(_query, _con);
				_rd = _cmd.ExecuteReader();
				if (_rd != null)
				{
					while (_rd.Read())
					{
						_variable = _rd["CPS_ISIM"] != DBNull.Value ? _rd["CPS_ISIM"].ToString() : "";
						gorusulenKisilerListe.Add(_variable!);
					}
				}

				_con.Close();
				return gorusulenKisilerListe;
			}
			catch (Exception e)
			{
				TempData["Failure"] = e.Message;
				_con.Close();
				return gorusulenKisilerListe;
			}
		}
		return new List<string>();
	}

	//GET DESTEK SEKLI LIST
	public List<String> GetDestekSekliList()
	{
		List<String> destekSekliList = new List<string>();
		try
		{
			_con.Open();
			_query = @"SELECT DEGER FROM TB_KOD where KOD=125";
			_cmd = new SqlCommand(_query, _con);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					_variable = _rd["DEGER"] != DBNull.Value ? _rd["DEGER"].ToString() : "";
					destekSekliList.Add(_variable!);
				}
			}

			_con.Close();
			return destekSekliList;
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			return destekSekliList;
		}
	}

	//GET DESTEK KONUSU LISTE
	public List<String> GetDestekKonusuListe()
	{
		List<String> konular = new List<string>();
		try
		{
			_con.Open();
			_query = "SELECT [TB_DESTEK_KONU_BASLIK] FROM [ORJINCRM].[dbo].[TB_DESTEK_KONU]";
			_cmd = new SqlCommand(_query, _con);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					_variable = _rd["TB_DESTEK_KONU_BASLIK"] != DBNull.Value ? _rd["TB_DESTEK_KONU_BASLIK"].ToString() : "";
					konular.Add(_variable!);
				}
			}

			_con.Close();
			return konular;
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			return konular;
		}
	}

	//GET PERSONEL EMAILS
	public List<String> GetPersonelEmails(string? firmaAdi)
	{
		List<String> emails = new List<string>();
		try
		{
			_con.Open();
			_query =
				$"select CPS_MAIL from TB_CARI_PERSONEL CPS  LEFT JOIN TB_CARI TC on CPS.CPS_CARI_ID = TC.TB_CARI_ID where CARI_UNVAN = '{firmaAdi}'";
			_cmd = new SqlCommand(_query, _con);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					if (_rd["CPS_MAIL"] != DBNull.Value)
					{
						_variable = _rd["CPS_MAIL"].ToString();
						emails.Add(_variable!);
					}
				}

				_con.Close();
				return emails;
			}

			_con.Close();
			return emails;

		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			return emails;
		}
	}

	//GET COMPLETED ACTIONS
	public List<TbDestekCevap> GetCompletedActions(int refNo)
	{
		List<TbDestekCevap> actions = new List<TbDestekCevap>();
		try
		{
			_con.Open();
			_query = $"SELECT YAPILAN_ISLEM, C.USER_NAME, DESTEK_TARIHI, BASLAMA_ZAMANI   FROM TB_DESTEK_CEVAP D LEFT JOIN TB_CRM_USER C ON  (D.TB_CRM_USER_ID=C.TB_CRM_USER_ID) WHERE TB_DESTEK_ID = {refNo}";
			_cmd = new SqlCommand(_query, _con);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					TbDestekCevap entity = new TbDestekCevap();
					entity.YapilanIslem = _rd["YAPILAN_ISLEM"] != DBNull.Value ? _rd["YAPILAN_ISLEM"].ToString() : "";
					entity.CrmUser = _rd["USER_NAME"] != DBNull.Value ? _rd["USER_NAME"].ToString() : "";
					entity.DestekTarihi = (_rd["DESTEK_TARIHI"] != DBNull.Value ? _rd["DESTEK_TARIHI"] : "") as DateTime?;
					entity.BaslamaZamani = (string?)(_rd["BASLAMA_ZAMANI"] != DBNull.Value ? _rd["BASLAMA_ZAMANI"] : "");
					actions.Add(entity);
				}
			}
			_con.Close();
			return actions;
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			return actions;
		}
	}

	//GET ACTIONS NUMBER
	public int GetActionsNumber(int refNo)
	{
		_query = $"select count(*) from TB_DESTEK_CEVAP D LEFT JOIN TB_CRM_USER C ON  (D.TB_CRM_USER_ID=C.TB_CRM_USER_ID) WHERE TB_DESTEK_ID = {refNo}";
		_con.Open();
		_cmd = new SqlCommand(_query, _con);
		int value = (int)_cmd.ExecuteScalar();
		_con.Close();
		return value;
	}

	//Add A New Action
	[HttpPost]
	public JsonResult AddNewAction(string action, int refNo, string[] mailsArray, string? konu)
	{
		try
		{
			_con.Open();
			_query =
				 $"insert into TB_DESTEK_CEVAP (DESTEK_TARIHI,YAPILAN_ISLEM,BASLAMA_ZAMANI,BITIS_ZAMANI,TB_CRM_USER_ID,TB_DESTEK_ID) ";
			_query += $" values ('{DateTime.Now.ToString("yyyy-MM-dd")}','{action}','{DateTime.Now.ToString("HH:mm:ss")}','',{_userService.Getuser().TbCrmUserId},{refNo})";
			_cmd = new SqlCommand(_query, _con);
			_cmd.ExecuteNonQuery();

			_con.Close();
			try
			{
				SendEmail(mailsArray, action, konu);
			}
			catch (Exception e)
			{
				return Json(e.Message);
			}

			return Json("true");

		}
		catch (Exception e)
		{
			return Json("Kayıt ekleme işlemi başarısız. Hata : " + e.Message);
		}
	}

	//GET USER EMAIL AND TEL NUMBER
	[HttpGet]
	public JsonResult GetUserInfo(string? name)
	{
		string? userTelNo = "";
		string? userMail = "";
		if (!name.IsNullOrEmpty())
		{
			try
			{
				_con.Open();
				_query =
					$" DECLARE @gorusulenKisiId INT;SELECT @gorusulenKisiId = TB_CARI_PERSONEL_ID FROM TB_CARI_PERSONEL WHERE CPS_ISIM='{name}' ";
				_query +=
					$" select CPS_CEP_TEL , CPS_MAIL from TB_CARI_PERSONEL where TB_CARI_PERSONEL_ID = @gorusulenKisiId ";
				_cmd = new SqlCommand(_query, _con);
				_rd = _cmd.ExecuteReader();
				if (_rd != null)
				{
					while (_rd.Read())
					{
						userTelNo = _rd["CPS_CEP_TEL"] != DBNull.Value ? _rd["CPS_CEP_TEL"].ToString() : "";
						userMail = _rd["CPS_MAIL"] != DBNull.Value ? _rd["CPS_MAIL"].ToString() : "";
					}

					_con.Close();
					return Json(new { UserTelNo = userTelNo, UserMail = userMail });
				}

				_con.Close();
				return Json("False");
			}
			catch (Exception e)
			{
				_con.Close();
				return Json("False");
			}
		}
		_con.Close();
		return Json("False");

	}

	//UPDATE THE RECORD
	[HttpPost]
	public IActionResult UpdateTheRecord(int refNo, string proje, string destekTipi, string userEmail, string userTelNo, string rvzBilgisi,
		string destekPersonel, string konu, string oncelik, string destekSekli, string durum, string istekler, string talepEden)
	{
		if (userEmail.IsNullOrEmpty()) userEmail = "";
		if (userTelNo.IsNullOrEmpty()) userTelNo = "";
		if (rvzBilgisi.IsNullOrEmpty()) rvzBilgisi = "";

		int oncelikId = 0;
		if (!oncelik.IsNullOrEmpty())
		{
			if (oncelik.ToLower().Equals("normal")) oncelikId = 1;
			else if (oncelik.ToLower().Equals("acil")) oncelikId = 2;
			else if (oncelik.ToLower().Equals("çok acil")) oncelikId = 3;
		}

		int isKapali = -1;
		if (!durum.IsNullOrEmpty())
		{
			if (durum.ToLower().Equals("açık")) isKapali = 0;
			else if (durum.ToLower().Equals("kapalı")) isKapali = 1;
		}
		try
		{
			_conToPm.Open();
			_cmd = new SqlCommand($"select TB_REVIZYON_ID from TB_REVIZYON WHERE TANIM = '{rvzBilgisi}'", _conToPm);
			int? rvzId = (int?)_cmd.ExecuteScalar();
			_con.Open();
			_query =
				$" DECLARE @projeId INT; SELECT @projeId = TB_PROGRAM_ID FROM TB_PROGRAM WHERE TANIM='{proje}' ";
			_query +=
				$" DECLARE @destekTipiId INT; SELECT @destekTipiId = TB_KOD_ID FROM TB_KOD WHERE DEGER='{destekTipi}' ";
			_query +=
				$"DECLARE @gorusulenKisiId INT;SELECT @gorusulenKisiId = TB_CARI_PERSONEL_ID FROM TB_CARI_PERSONEL WHERE CPS_ISIM='{talepEden}'";
			_query +=
				$" DECLARE @perSonelId INT; SELECT @personelId = TB_CRM_USER_ID FROM TB_CRM_USER WHERE USER_NAME='{destekPersonel} '";
			_query +=
				$" DECLARE @konuId INT;select @konuId=TB_DESTEK_KONU_ID from dbo.TB_DESTEK_KONU where TB_DESTEK_KONU_BASLIK = '{konu}' ";
			_query +=
				$" DECLARE @destekSekliId INT; SELECT @destekSekliId = TB_KOD_ID FROM TB_KOD WHERE DEGER='{destekSekli}' ";
			_query +=
				$" update TB_DESTEK set DSK_PROGRAM_ID = @projeId , DSK_TALEP_SEBEP_ID = @destekTipiId , DSK_PERSONEL_ID = @perSonelId , DSK_KONU_ID = @konuId , DSK_DESTEK_TIPI_ID = @destekSekliId , DSK_KONU_BASLIK = '{konu}' , ";
			_query +=
				$" DSK_GORUSULEN_KISI_ID = @gorusulenKisiId ,DSK_KAPALI = {isKapali} , DSK_ONCELIK_ID = {oncelikId} , DSK_ISTEKLER = '{istekler}' ,DSK_TELEFON = '{userTelNo}'  ,DSK_EPOSTA = '{userEmail}' , DSK_REVIZYON_ID = {rvzId} WHERE TB_DESTEK_ID = {refNo} ";

			_cmd = new SqlCommand(_query, _con);
			_cmd.ExecuteNonQuery();
			TempData["Success"] = "Kayıt başarılı bir şekilde güncellendi.";
			_con.Close();
			return RedirectToAction("Index", "Home", new { token = _token.GetToken() });

		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			return RedirectToAction("Index", "Home", new { token = _token.GetToken() });
		}
	}

	//SEND EMAIL
	public JsonResult SendEmail(string[] mailsArray, string? yapilanIslem, string? konu)
	{
		if (mailsArray.Length != 0)
		{
			try
			{
				foreach (var s in mailsArray)
				{
					var sender = new SmtpSender(() => new System.Net.Mail.SmtpClient("mail.orjin.net")
					{
						UseDefaultCredentials = false,
						Port = 587,
						Credentials = new System.Net.NetworkCredential("bilgi@orjin.net", "dzMxSbiR6"),
						EnableSsl = true,
					});
					string footerText = "Bu e-posta ORJIN Yazılım Hiz.Ltd.Şti Destek Ekibi tarafından gönderilmiştir.";
					var footerHtml = "<html><head><style>.footer { opacity: 0.5; margin-top:100px }</style></head><body><div class=\"footer\"><h4>" + footerText + "</h4></div></body></html>";
					var email = Email
						.From("destek@orjin.net")
						.To(s)
						.Subject("Orjin Yazılım Destek Ekibi ( " + konu + " )")
						.Body(yapilanIslem + footerHtml, isHtml: true);

					sender.SendAsync(email);
				}
				return Json(true);
			}
			catch (Exception e)
			{
				return Json(new { valid = "false", message = e.Message });
			}
		}

		return Json("");
	}
}