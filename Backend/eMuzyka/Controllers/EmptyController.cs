using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzyka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmptyController : ControllerBase
    {

        [HttpGet]
        public void Get()
        {
            return;
        }
    }
}
