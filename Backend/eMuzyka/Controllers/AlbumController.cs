using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using eMuzyka.DTO.Album;
using eMuzyka.DTO.Provider;
using eMuzyka.Services;
using Microsoft.AspNetCore.Authorization;


namespace eMuzyka.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }


        [HttpGet]
        [Route("provider")]
        public ActionResult<IEnumerable<AlbumDto>> GetAllByProviderId()
        {
            var result = _albumService.GetAllByProvider();
            return Ok(result);
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<AlbumDto> GetById([FromRoute]int id)
        {
            var result = _albumService.GetById(id);
            return Ok(result);
        }


        [HttpGet]
        [Route("{id}/tracks")]
        public ActionResult<AlbumWTracksDto> GetWithTracksById([FromRoute] int id)
        {
            var result = _albumService.GetWithTracksById(id);
            return Ok(result);
        }
    }
}
