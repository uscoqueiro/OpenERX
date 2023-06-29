using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using OpenERX.Commons.Results;
using OpenERX.Core.Customers;
using OpenERX.Core.SignIns;

namespace OpenERX.Services.SignIns
{
    public class SignInService : ResultService, ISignInService
    {
        public SignInService(
        )
        {

        }

        public async Task<SignInResult> SignInAsync(SignInParams @params)
        {
            try
            {

                if (!(@params.AccessKey == "uilan" && @params.Password == "123456"))
                {
                    this.AddMessage(new ResultMessage(ResultMessageTypes.Error, "Usuário ou senha inválidos", "401"));
                    return null;
                }


                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(Settings.Secret);
                var expires = DateTime.UtcNow.AddDays(1);

                var descriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserId", "123341625656"),
                        new Claim("SessionId", "13232323232323")
                    }),
                    Expires = expires,
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(descriptor);
                var result = tokenHandler.WriteToken(token);

                return new SignInResult
                {
                    Token= result,
                    Expires = expires
                };
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
