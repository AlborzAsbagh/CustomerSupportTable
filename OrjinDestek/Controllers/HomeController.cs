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

public class HomeController : Controller
{

    private SqlConnection _con;
    private SqlCommand _cmd = null!;
    private readonly IUsuerService _userService;
    private readonly IToken _token;
    private readonly ITokenValidate _tokenValidate;
    public HomeController(IConfiguration configuration, IUsuerService userService, IToken token, ITokenValidate tokenValidate)
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

    public List<DestekTabloModel> GetTable(string? token)
    {
        if (!token.IsNullOrEmpty() && token!.Equals(_token.GetToken()))
        {
            _con.Open();
            string query = @"SELECT
            D.TB_DESTEK_ID as RefNo
                ,case
            WHEN [DSK_KAPALI]=1 then 'KAPALI'
            WHEN [DSK_KAPALI]=0 then 'AÇIK'
            ELSE NULL
            end AS DURUM
                , [DSK_BASLAMA_TARIHI] As Tarih
                ,C.CARI_UNVAN as Firma
                ,P.TANIM as Proje
                ,[DSK_KONU_BASLIK] as Konu
                ,CP.CPS_ISIM as TalepEden
                ,CU3.USER_NAME AS DestekPersonel
			    ,dbo.UDF_BEKLEME_SURESI_HESAP(TB_DESTEK_ID) AS GecenSure
                ,DSK_REVIZYON_Id
            
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
            LEFT OUTER JOIN TB_KOD K3 ON(K3.TB_KOD_ID=DSK_TALEP_SEBEP_ID)
            WHERE DSK_BASLAMA_TARIHI>'2022-01-01 00:00:00.000'
            ORDER BY DSK_KAPALI ASC, DSK_BASLAMA_TARIHI DESC";
            List<DestekTabloModel> tabloList = new List<DestekTabloModel>();
            try
            {
                _cmd = new SqlCommand(query, _con);
                SqlDataReader dr = _cmd.ExecuteReader();
                if (dr != null)
                {

                    while (dr.Read())
                    {
                        DestekTabloModel destekTabloModel = new DestekTabloModel();
                        destekTabloModel.RefNo = Convert.ToInt32(dr["RefNo"]);
                        destekTabloModel.Durum = dr["Durum"] != DBNull.Value ? dr["Durum"].ToString() : "";
                        destekTabloModel.Tarih = dr["Tarih"] != DBNull.Value ? dr["Tarih"].ToString() : "";
                        destekTabloModel.Firma = dr["Firma"] != DBNull.Value ? dr["Firma"].ToString() : "";
                        destekTabloModel.Proje = dr["Proje"] != DBNull.Value ? dr["Proje"].ToString() : "";
                        destekTabloModel.Konu = dr["Konu"] != DBNull.Value ? dr["Konu"].ToString() : "";
                        destekTabloModel.TalepEden = dr["TalepEden"] != DBNull.Value ? dr["TalepEden"].ToString() : "";
                        destekTabloModel.DestekPersonel = dr["DestekPersonel"] != DBNull.Value ? dr["DestekPersonel"].ToString() : "";
                        destekTabloModel.GecenSure = dr["GecenSure"] != DBNull.Value ? dr["GecenSure"].ToString() : "";
                        destekTabloModel.RevizyonId = (int?)(Convert.ToInt32(dr["DSK_REVIZYON_ID"]) != 0 ? dr["DSK_REVIZYON_ID"] : 0);
                        tabloList.Add(destekTabloModel);
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