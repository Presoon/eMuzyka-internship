using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using eMuzyka.Database;
using eMuzyka.DTO.Provider;
using eMuzyka.Entities;
using eMuzyka.Services;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace eMuzyka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderService _providerService;

        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
        }


        [HttpGet]
        [Route("all")]
        public ActionResult<IEnumerable<ProviderDto>> GetAll()
        {
            var result = _providerService.GetAll();
            return Ok(result);
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<ProviderDto> GetById([FromRoute]int id)
        {
            var result = _providerService.GetById(id);
            return Ok(result);
        }
    }
}
