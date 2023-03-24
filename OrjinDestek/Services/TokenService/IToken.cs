#nullable enable
namespace OrjinDestek.Services.TokenService;

public interface IToken
{
    String GetToken();
    public void SetToken(string? token);
}