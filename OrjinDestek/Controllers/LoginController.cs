using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using OrjinDestek.Models;
using OrjinDestek.Services.TokenService;
using OrjinDestek.Services.UserService;

namespace OrjinDestek.Controllers;

public class LoginController : Controller
{
    private readonly SqlConnection _con;
    private SqlCommand _cmd = null!;
    private readonly IUsuerService _userService;
    private readonly IConfiguration _configuration;
    private readonly IToken _token;

    public LoginController(IConfiguration configuration, IUsuerService userService, IToken token)
    {
        _configuration = configuration;
        _con = new SqlConnection(configuration.GetConnectionString("Default"));
        _userService = userService;
        _token = token;
    }

    public IActionResult Index()
    {
        return View();
    }


    [HttpGet]
    public JsonResult GetTheUser(string? userNo, string? userPassword)
    {
        try
        {
            _con.Open();
            string query =
                $"  select count(*) from dbo.TB_CRM_USER where USER_PASSWORD = '{userPassword}' and USER_CODE = '{userNo}' and AKTIF = 1 ";
            _cmd = new SqlCommand(query, _con);
            int count = (int)_cmd.ExecuteScalar();
            if (count == 0)
            {
                _con.Close();
                return Json("False");
            }

            query =
                $"select * from dbo.TB_CRM_USER where USER_PASSWORD = '{userPassword}' and USER_CODE = '{userNo}' and AKTIF = 1 ";
            _cmd = new SqlCommand(query, _con);
            SqlDataReader rd = _cmd.ExecuteReader();
            TbCrmUser loggedInUser = new TbCrmUser();
            if (rd != null)
            {
                while (rd.Read())
                {
                    loggedInUser.TbCrmUserId = Convert.ToInt32(rd["TB_CRM_USER_ID"]);
                    loggedInUser.UserName = rd["USER_NAME"] != DBNull.Value ? rd["USER_NAME"].ToString() : "";
                }
                _userService.SetUser(loggedInUser);
                _con.Close();
                return Json(GenerateToken(userNo));
            }

            return Json("False");
        }
        catch (Exception e)
        {
            _con.Close();
            return Json(e.Message);
        }
    }

    //GENERATE TOKEN
    [HttpGet]
    public String GenerateToken(string? userNo)
    {

        var tokenHandler = new JwtSecurityTokenHandler();
        var jwtSettings = _configuration.GetSection("JWT");
        var secKey = jwtSettings.GetValue<String>("SecretKey");
        var issuer = jwtSettings.GetValue<String>("Issuer");
        var audience = jwtSettings.GetValue<String>("Audience");
        var key = Encoding.UTF8.GetBytes(secKey!);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, userNo!)
            }),
            Issuer = issuer,
            Audience = audience,
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var tokenKey = tokenHandler.WriteToken(token);
        _token.SetToken(tokenKey);
        return tokenKey;

    }
}