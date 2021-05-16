using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using eMuzyka.DTO.Provider;
using eMuzyka.Services;
using Microsoft.AspNetCore.Authorization;


namespace eMuzyka.Controllers
{
    [Authorize]
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
        [Route("me")]
        public ActionResult<ProviderDto> GetById()
        {
            var result = _providerService.GetFromUserContext();
            return Ok(result);
        }
    }
}
