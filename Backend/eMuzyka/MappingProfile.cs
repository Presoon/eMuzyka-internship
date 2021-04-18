using AutoMapper;
using eMuzyka.DTO.Provider;
using eMuzyka.Entities;

namespace eMuzyka
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Provider, ProviderDto>();
        }
    }
}