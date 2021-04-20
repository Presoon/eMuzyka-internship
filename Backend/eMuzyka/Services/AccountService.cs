using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using eMuzyka.Authentication;
using eMuzyka.Infrastructure.Database;
using eMuzyka.DTO.Provider;
using eMuzyka.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;


namespace eMuzyka.Services
{
    public interface IAccountService
    {
        void RegisterProvider(RegisterProviderDto dto);

        string GenerateJwt(LoginProviderDto dto);
    }

    public class AccountService : IAccountService
    {
        private readonly DatabaseContext _context;
        private readonly IPasswordHasher<Provider> _passwordHasher;
        private readonly AuthenticationSettings _authSettings;

        public AccountService(DatabaseContext context, IPasswordHasher<Provider> passwordHasher, AuthenticationSettings authSettings)
        { 
            _context = context;
            _passwordHasher = passwordHasher;
            _authSettings = authSettings;
        }

        public void RegisterProvider(RegisterProviderDto dto)
        {
            var newProvider = new Provider()
            {
                Name = dto.Name,
                LastName = dto.LastName,
                Email = dto.Email,
                UserName = dto.UserName,
                CreatedAt = DateTime.Now
            };

            var hashedPassword = _passwordHasher.HashPassword(newProvider, dto.Password);
            newProvider.Password = hashedPassword;

            _context.Providers.Add(newProvider);
            _context.SaveChanges();

        }

        public string GenerateJwt(LoginProviderDto dto)
        {
            var user = _context.Providers.FirstOrDefault(u => u.UserName == dto.UserName);

            if (user is null)
            {
                throw new BadHttpRequestException("Invalid Username or Password");
            }

            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, dto.Password);
            if (result == PasswordVerificationResult.Failed)
            {
                throw new BadHttpRequestException("Invalid Username or Password");
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim("Personal Info", $"{user.Name} {user.LastName}"),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authSettings.JwtKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authSettings.JwtExpireDays);

            var token = new JwtSecurityToken(
                _authSettings.JwtIssuer,
                _authSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: credentials
            );

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);

        }
    }
}
