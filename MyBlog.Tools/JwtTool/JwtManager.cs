using Microsoft.IdentityModel.Tokens;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Tools.JWT;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MyBlog.Tools.JwtTool
{
    public class JwtManager : IJwtService
    {
        public JwtToken Token(AppUser appUser)
        {

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtInfo.SecurityKey));

            SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: JwtInfo.Issuer, audience: JwtInfo.Auidence, claims: Claims(appUser), notBefore: DateTime.Now, expires:DateTime.Now.AddMinutes(40), signingCredentials: signingCredentials);


            JwtToken jwtToken = new JwtToken();
            JwtSecurityTokenHandler jwt = new JwtSecurityTokenHandler();
            jwtToken.Token = jwt.WriteToken(jwtSecurityToken);

            return jwtToken;
        }

        private List<Claim> Claims(AppUser appUser)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, appUser.Name));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, appUser.ID.ToString()));

            return claims;


        }
    }
}
