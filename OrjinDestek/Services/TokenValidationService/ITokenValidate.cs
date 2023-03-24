namespace OrjinDestek.Services.TokenValidationService;

public interface ITokenValidate
{
    Boolean IsTokenValid(string? token);
}