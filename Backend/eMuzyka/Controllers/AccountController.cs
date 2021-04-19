using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzyka.DTO.Provider;
using eMuzyka.Services;
using Microsoft.AspNetCore.Mvc;

namespace eMuzyka.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        [Route("register")]
        public ActionResult RegisterProvider([FromBody] RegisterProviderDto registerProvider)
        {

            _accountService.RegisterProvider(registerProvider);
            return Ok();
        }

    }
}
