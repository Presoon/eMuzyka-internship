using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzyka.Database;
using eMuzyka.Entities;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace eMuzyka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProviderController : ControllerBase
    {
        private readonly DatabaseContext _dbContext;

        public ProviderController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("all")]
        public ActionResult<IEnumerable<Provider>> GetAll()
        {
            var providers = _dbContext.Providers.ToList();
            return Ok(providers);
        }
    }
}
