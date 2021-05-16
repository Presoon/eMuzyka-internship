using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eMuzyka.Infrastructure.Database;
using eMuzyka.DTO.Provider;
using eMuzyka.Domain.Entities;
using eMuzyka.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace eMuzyka.Services
{
    public interface IProviderService
    {
        ProviderDto GetFromUserContext();
        IEnumerable<ProviderDto> GetAll();
    }

    public class ProviderService : IProviderService
    {
        private readonly DatabaseContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<ProviderService> _logger;
        private readonly IUserContextService _userContextService;

        public ProviderService(DatabaseContext dbContext, IMapper mapper, ILogger<ProviderService> logger, IUserContextService userContextService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
            _userContextService = userContextService;
        }
        public ProviderDto GetFromUserContext()
        {
            var provider = _dbContext
                .Providers
                .Include(r => r.Albums)
                .FirstOrDefault(r => r.Id == _userContextService.GetUserId);

            if (provider is null) throw new NotFoundException("Provider not found!");

            var result = _mapper.Map<ProviderDto>(provider);
            return result;
        }



        public IEnumerable<ProviderDto> GetAll()
        {
            _logger.LogInformation("Get All Providers method invoked");

            var providers = _dbContext
                .Providers
                .ToList();

            var result = _mapper.Map<List<ProviderDto>>(providers);
            return result;
        }
    }
}