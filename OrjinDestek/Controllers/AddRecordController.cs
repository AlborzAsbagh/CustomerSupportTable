#nullable enable
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Dynamic;
using Microsoft.IdentityModel.Tokens;
using OrjinDestek.Models;
using OrjinDestek.Services.TokenService;
using OrjinDestek.Services.TokenValidationService;


namespace OrjinDestek.Controllers;

public class AddRecordController : Controller
{
	private readonly SqlConnection _con;
	private readonly SqlConnection _conToPm;
	private SqlCommand _cmd = null!;
	private SqlDataReader _rd = null!;
	private string? _query;
	private string? _variable;
	private readonly IToken _token;
	private readonly ITokenValidate _tokenValidate;

	public AddRecordController(IConfiguration configuration, IToken token, ITokenValidate tokenValidate)
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
			dy.durumList = GetDurumListe();
			dy.personelList = GetDestekPersonelList();
			dy.destekSekliList = GetDestekSekliList();
			dy.destekKonusuList = GetDestekKonusuListe();
			dy.destekTipleri = GetDestekTipiListe();
			dy.getFirmalarListe = GetFirmalarListe();
			dy.getProjeler = GetProjeler();
			dy.token = token;
			return View(dy);

		}
		return RedirectToAction("Index", "Login");
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

	//GET FIRMALAR LIST
	public List<String> GetFirmalarListe()
	{
		List<String> firmalarListe = new List<string>();
		try
		{
			_con.Open();
			_query = @"SELECT CARI_UNVAN FROM TB_CARI";
			_cmd = new SqlCommand(_query, _con);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					_variable = _rd["CARI_UNVAN"] != DBNull.Value ? _rd["CARI_UNVAN"].ToString() : "";
					firmalarListe.Add(_variable!);
				}
			}

			_con.Close();
			return firmalarListe;
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_con.Close();
			return firmalarListe;
		}
	}

	//GET GORUSULEN KISILER LIST
	[HttpGet]
	public JsonResult GetGorusulenKisilerListe(string? firmaAdi)
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
				return Json(gorusulenKisilerListe);
			}
			catch (Exception e)
			{
				_con.Close();
				return Json(e.Message);
			}
		}
		return null!;
	}

	//GET KISI MAIL

	[HttpGet]
	public JsonResult GetKisiMail(string? kisiAdi)
	{
		if (!kisiAdi.IsNullOrEmpty())
		{
			try
			{
				_con.Open();
				_query = "select CPS_MAIL from TB_CARI_PERSONEL CPS " +
						 $" LEFT JOIN TB_CARI TC on CPS.CPS_CARI_ID = TC.TB_CARI_ID where CPS_ISIM = '{kisiAdi}'";
				_cmd = new SqlCommand(_query, _con);
				_rd = _cmd.ExecuteReader();
				if (_rd != null)
				{
					while (_rd.Read())
					{
						_variable = _rd["CPS_MAIL"] != DBNull.Value ? _rd["CPS_MAIL"].ToString() : "";
					}
				}

				_con.Close();
				return Json(_variable!);
			}
			catch (Exception e)
			{
				_con.Close();
				return Json(e.Message);
			}
		}

		return null!;
	}

	//GET KISI TEL

	public JsonResult GetKisiTelefon(string? kisiAdi)
	{
		if (!kisiAdi.IsNullOrEmpty())
		{
			try
			{
				_con.Open();
				_query = "select CPS_CEP_TEL  from TB_CARI_PERSONEL CPS " +
						 $" LEFT JOIN TB_CARI TC on CPS.CPS_CARI_ID = TC.TB_CARI_ID where CPS_ISIM = '{kisiAdi}'";
				_cmd = new SqlCommand(_query, _con);
				_rd = _cmd.ExecuteReader();
				if (_rd != null)
				{
					while (_rd.Read())
					{
						_variable = _rd["CPS_CEP_TEL"] != DBNull.Value ? _rd["CPS_CEP_TEL"].ToString() : "";
					}
				}

				_con.Close();
				return Json(_variable!);
			}
			catch (Exception e)
			{
				_con.Close();
				return Json(e.Message);
			}
		}

		return null!;
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

	//GET REVIZIYON BILGI
	[HttpGet]
	public JsonResult GetRevizyonBilgileri(string? projeAdi)
	{
		List<String> rvzBilgiler = new List<string>();
		try
		{
			_conToPm.Open();
			_query = $" DECLARE @projeId INT ; DECLARE @projetanim VARCHAR(50); SELECT @projetanim =   [TANIM] FROM [ORJINCRM].[dbo].[TB_PROGRAM] WHERE TANIM='{projeAdi}' ";
			_query += @" SET @projeId =  			
	                    CASE 
			                    WHEN @projetanim = 'ATSPRO'  THEN  10
			                    WHEN @projetanim = 'PBTPRO'  THEN  16
			                    WHEN @projetanim = 'PBTPLUS'  THEN  2
			                    WHEN @projetanim = 'OMEGA'  THEN  21
			                    WHEN @projetanim = 'ORJİN SUPPORT'  THEN  34
			                    WHEN @projetanim = 'ORION'  THEN  30
	                    end;
	                    
                    SELECT R.[TANIM] FROM [ORJIN_PM].[dbo].[TB_REVIZYON] R
                      RIGHT outer JOIN [TB_VERSIYON] V ON (V.TB_VERSIYON_ID=R.TB_VERSIYON_ID)
                      RIGHT outer JOIN TB_PROJE P ON (V.TB_PROJE_ID=P.TB_PROJE_ID)
                      WHERE P.TB_PROJE_ID = @projeId and  R.AKTIF ='1'
                      GROUP BY P.TANIM, V.TANIM, R.TANIM
                      ORDER BY V.TANIM ";
			_cmd = new SqlCommand(_query, _conToPm);
			_rd = _cmd.ExecuteReader();
			if (_rd != null)
			{
				while (_rd.Read())
				{
					_variable = _rd["TANIM"] != DBNull.Value ? _rd["TANIM"].ToString() : " ";
					rvzBilgiler.Add(_variable!);
				}
			}
			_conToPm.Close();
			return Json(rvzBilgiler);
		}
		catch (Exception e)
		{
			TempData["Failure"] = e.Message;
			_conToPm.Close();
			return Json("false");
		}
	}

	//ADD NEW RECORD
	[HttpPost]
	public IActionResult AddNewRecord(DestekTabloModel model)
	{
		int oncelikId = 0;
		if (!model.Oncelik.IsNullOrEmpty())
		{
			if (model.Oncelik!.ToLower().Equals("normal")) oncelikId = 1;
			else if (model.Oncelik!.ToLower().Equals("acil")) oncelikId = 2;
			else if (model.Oncelik!.ToLower().Equals("çok acil")) oncelikId = 3;
		}
		try
		{
			_conToPm.Open();
			_query = $"  select TB_REVIZYON_ID from TB_REVIZYON WHERE TANIM = '{model.RevizyonBilgisi}' ";
			_cmd = new SqlCommand(_query, _conToPm);
			var rvzId = Convert.ToInt32(_cmd.ExecuteScalar());
			_conToPm.Close();
			_query = $" DECLARE @firmaId INT; SELECT @firmaId = TB_CARI_ID FROM TB_CARI WHERE CARI_UNVAN = '{model.Firma}' ";

			_query +=
				$" DECLARE @gorusulenKisiId INT; SELECT @gorusulenKisiId = TB_CARI_PERSONEL_ID FROM TB_CARI_PERSONEL WHERE CPS_ISIM='{model.TalepEden}' ";

			_query +=
				$" DECLARE @projeId INT; SELECT @projeId = TB_PROGRAM_ID FROM TB_PROGRAM WHERE TANIM='{model.Proje}' ";

			_query +=
				$" DECLARE @destekTipiId INT; SELECT @destekTipiId = TB_KOD_ID FROM TB_KOD WHERE DEGER='{model.DestekTipi}' ";

			_query +=
				$" DECLARE @destekSekliId INT; SELECT @destekSekliId = TB_KOD_ID FROM TB_KOD WHERE DEGER='{model.DestekSekli}' ";

			_query +=
				$" DECLARE @konuId INT;select @konuId=TB_DESTEK_KONU_ID from dbo.TB_DESTEK_KONU where TB_DESTEK_KONU_BASLIK = '{model.Konu}' ";

			_query +=
				$" DECLARE @perSonelId INT; SELECT @personelId = TB_CRM_USER_ID FROM TB_CRM_USER WHERE USER_NAME='{model.DestekPersonel}' ";
			_query +=
				" DECLARE @tarih DATETIME;SELECT @tarih=CONVERT(datetimeoffset, GETDATE()) ";
			_query +=
				" DECLARE @saat TIME;SELECT @saat = CONVERT(time, GETDATE()) ";
			_query +=
				@"
            INSERT INTO TB_DESTEK 
                (DSK_FIRMA_ID 
                    ,DSK_GORUSULEN_KISI_ID 
                    ,DSK_EPOSTA 
                    ,DSK_TELEFON 
                    ,DSK_PROGRAM_ID 
                    ,DSK_TALEP_SEBEP_ID 
                    ,DSK_KONU_ID
                    ,DSK_KONU_BASLIK 
                    ,DSK_DESTEK_TIPI_ID 
                    ,DSK_BASLAMA_TARIHI 
                    ,DSK_BASLAMA_SAATI 
                    ,DSK_PERSONEL_ID 
                    ,DSK_ONCELIK_ID
                    ,DSK_KAPALI
                    ,[DSK_ISTEKLER]
                    ,DSK_REVIZYON_ID
                ) ";
			_query +=
				$" VALUES (@firmaId , @gorusulenKisiId ,'{model.EmailHesabi}', '{model.TelNo}' , @projeId , @destekTipiId , @konuId , '{model.Konu}' , @destekSekliId ,@tarih, @saat , @perSonelId , {oncelikId} , 0 , '{model.Aciklama}' , {rvzId}) ";

			using (SqlCommand command = new SqlCommand(_query, _con))
			{
				// Open the SqlConnection object
				_con.Open();

				// Execute the SqlCommand object using the ExecuteNonQuery method
				command.ExecuteNonQuery();

				// Close the SqlConnection object
				_con.Close();
			}

			TempData["Success"] = "Kayıt başarılı şekilde eklendi";
			return RedirectToAction("Index", "Home", new { token = _token.GetToken() });
		}
		catch (Exception e)
		{
			_con.Close();
			TempData["Failure"] = e.Message;
			return RedirectToAction("Index", "Home", new { token = _token.GetToken() });
		}
	}
}