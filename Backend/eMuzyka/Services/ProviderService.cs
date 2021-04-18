using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eMuzyka.Database;
using eMuzyka.DTO.Provider;
using eMuzyka.Entities;

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

        public ProviderService(DatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public ProviderDto GetById(int id)
        {
            var provider = _dbContext
                .Providers
                .FirstOrDefault(r => r.Id == id);

            if (provider is null) return null;

            var result = _mapper.Map<ProviderDto>(provider);
            return result;
        }

        public IEnumerable<ProviderDto> GetAll()
        {
            var providers = _dbContext
                .Providers
                .ToList();

            var result = _mapper.Map<List<ProviderDto>>(providers);
            return result;
        }
    }
}