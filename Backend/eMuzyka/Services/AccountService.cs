using System;
using System.Collections.Generic;
using System.Linq;
using eMuzyka.Database;
using eMuzyka.DTO.Provider;
using eMuzyka.Domain.Entities;
using Microsoft.AspNetCore.Identity;


namespace eMuzyka.Services
{
    public interface IAccountService
    {
        void RegisterProvider(RegisterProviderDto dto);
    }

    public class AccountService : IAccountService
    {
        private readonly DatabaseContext _context;
        private readonly IPasswordHasher<Provider> _passwordHasher;

        public AccountService(DatabaseContext context, IPasswordHasher<Provider> passwordHasher)
        { 
            _context = context;
            _passwordHasher = passwordHasher;
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
    }
}
