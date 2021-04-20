using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using eMuzyka.DTO.Album;
using eMuzyka.DTO.Provider;
using eMuzyka.Services;


namespace eMuzyka.Controllers
{
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
        [Route("{id}/all")]
        public ActionResult<IEnumerable<AlbumDto>> GetAllByProviderId([FromRoute] int id)
        {
            var result = _albumService.GetAllByProviderId(id);
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
