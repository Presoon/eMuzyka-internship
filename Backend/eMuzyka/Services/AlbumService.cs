using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using AutoMapper;
using eMuzyka.Authorization;
using eMuzyka.Infrastructure.Database;
using eMuzyka.DTO.Album;
using eMuzyka.DTO.Provider;

using eMuzyka.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace eMuzyka.Services
{
    public interface IAlbumService
    {
        AlbumDto GetById(int id);
        AlbumWTracksDto GetWithTracksById(int id);
        IEnumerable<AlbumDto> GetAllByProviderId(int id);
    }

    public class AlbumService : IAlbumService
    {
        private readonly DatabaseContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<ProviderService> _logger;
        private readonly IAuthorizationService _authorizationService;
        private readonly IUserContextService _userContextService;

        public AlbumService(DatabaseContext dbContext, IMapper mapper, ILogger<ProviderService> logger, 
            IAuthorizationService authorizationService, IUserContextService userContextService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
            _authorizationService = authorizationService;
            _userContextService = userContextService;
        }
        public AlbumDto GetById(int id)
        { 
            var album = _dbContext
                .Albums
                .FirstOrDefault(r => r.Id == id);

            if (album is null) throw new NotFoundException($"Album with id: {id} not found!");

            var authorizationResult = _authorizationService
                .AuthorizeAsync(_userContextService.User, album, new ResourceOperationRequirement()).Result;

            if (!authorizationResult.Succeeded) throw new ForbidException();

            var result = _mapper.Map<AlbumDto>(album);
            return result;
        }

        public AlbumWTracksDto GetWithTracksById(int id)
        {
            var album = _dbContext
                .Albums
                .Include(r=> r.Tracks)
                .FirstOrDefault(r => r.Id == id);

            if (album is null) throw new NotFoundException($"Album with id: {id} not found!");

            var authorizationResult = _authorizationService
                .AuthorizeAsync(_userContextService.User, album, new ResourceOperationRequirement()).Result;

            if (!authorizationResult.Succeeded) throw new ForbidException();

            var result = _mapper.Map<AlbumWTracksDto>(album);
            return result;
        }


        public IEnumerable<AlbumDto> GetAllByProviderId(int id)
        {
            _logger.LogInformation("Get all Provider's Albums method invoked");

            var albums = _dbContext
                .Albums
                .Where(r =>r.ProviderId == id)
                .ToList();

            if (albums is null) throw new NotFoundException($"There's no albums from provider with id: {id}!");


            var authorizationResult = _authorizationService
                .AuthorizeAsync(_userContextService.User, id, new ResourceOperationRequirement()).Result;

            if (!authorizationResult.Succeeded) throw new ForbidException();

            var result = _mapper.Map<List<AlbumDto>>(albums);
            return result;
        }
    }
}