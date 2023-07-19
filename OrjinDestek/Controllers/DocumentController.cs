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

public class DocumentController : Controller
{

	private SqlConnection _con;
	private SqlCommand _cmd = null!;
	private readonly IUsuerService _userService;
	private readonly IToken _token;
	private readonly ITokenValidate _tokenValidate;
	public DocumentController(IConfiguration configuration, IUsuerService userService, IToken token, ITokenValidate tokenValidate)
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
			dy.user = _userService.Getuser();
			dy.token = token;
			return View(dy);
		}

		return RedirectToAction("Index", "Login");

	}


	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}

}