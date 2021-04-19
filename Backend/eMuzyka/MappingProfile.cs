using AutoMapper;
using eMuzyka.DTO.Album;
using eMuzyka.DTO.Provider;
using eMuzyka.Entities;

namespace eMuzyka
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Provider, ProviderDto>().ReverseMap();

            CreateMap<Album, AlbumDto>().ReverseMap();
            CreateMap<Album, AlbumWTracksDto>().ReverseMap();
        }
    }
}