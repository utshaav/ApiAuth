using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;

namespace ApiAuth.Services
{
    public class TokenService
    {
        public string CreateToken()
        {

            List<Claim> claims = new List<Claim>{
            new Claim(ClaimTypes.Name, "SimpleApiUser")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Global.SecretKey!));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddMinutes(30),
                SigningCredentials = credential

            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

    }
}