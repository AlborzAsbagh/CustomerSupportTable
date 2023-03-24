#nullable enable
using Microsoft.IdentityModel.Tokens;

namespace OrjinDestek.Services.TokenService;

public class TokenService:IToken
{
    private string? _token;
    public string GetToken()
    {
        return _token!;
    }

    public void SetToken(string? token)
    {
        _token = token;
    }
}