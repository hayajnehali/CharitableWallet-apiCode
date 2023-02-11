using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class JWTService : IJWTService
    {
        private readonly IJWTRepository repository;
        public JWTService(IJWTRepository  repository)
        {
            this.repository = repository;
        }
        public string Auth(User login)
        {
            var result = repository.Auth(login);
            if(result ==null)
            {
                return null;
            }
            else
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("supersecretkey@321"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
                {
                     new Claim("Name",result.Username),
                     new Claim("Role",result.RoleidFk.ToString()),
                     new Claim("USERID",result.Userid.ToString()),
                     new Claim("IsAccepted",result.Isaccepted.ToString()),


                };
                var tokenOptions = new JwtSecurityToken
                    (
                        claims: claims,
                        expires: DateTime.Now.AddSeconds(10),
                        signingCredentials: signinCredentials
                    );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return tokenString;
            }
        }
        
    }
}
