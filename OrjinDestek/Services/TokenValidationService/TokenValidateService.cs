using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace OrjinDestek.Services.TokenValidationService;

public class TokenValidateService:ITokenValidate
{
    public bool IsTokenValid(string token)
    {
        var tokenString = token;


        var tokenHandler = new JwtSecurityTokenHandler();

        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("MySecretKey5503!")),
            ValidateIssuer = false,
            ValidateAudience = false,
            ClockSkew = TimeSpan.Zero 
        };

        try
        {
            
            var principal = tokenHandler.ValidateToken(tokenString, validationParameters, out var validatedToken);
            
            var expires = validatedToken.ValidTo;

            
            if (expires < DateTime.UtcNow)
            {
                return false;
            }

            return true;

        }
        catch (SecurityTokenException)
        {
            return false;
        }
    }
}