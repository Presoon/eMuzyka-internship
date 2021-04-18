using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eMuzyka.Database;
using eMuzyka.DTO.Provider;
using eMuzyka.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace eMuzyka.Services
{
    public interface IProviderService
    {
        ProviderDto GetById(int id);
        IEnumerable<ProviderDto> GetAll();
    }

    public class ProviderService : IProviderService
    {
        private readonly DatabaseContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<ProviderService> _logger;

        public ProviderService(DatabaseContext dbContext, IMapper mapper, ILogger<ProviderService> logger)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }
        public ProviderDto GetById(int id)
        {
            var provider = _dbContext
                .Providers
                .Include(r => r.Albums)
                .FirstOrDefault(r => r.Id == id);

            if (provider is null) return null;

            var result = _mapper.Map<ProviderDto>(provider);
            return result;
        }

        public IEnumerable<ProviderDto> GetAll()
        {
            _logger.LogInformation("Get All Providers method on API");

            var providers = _dbContext
                .Providers
                .ToList();

            var result = _mapper.Map<List<ProviderDto>>(providers);
            return result;
        }
    }
}