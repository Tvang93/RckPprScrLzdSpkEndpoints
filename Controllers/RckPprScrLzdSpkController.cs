using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RckPprScrLzdSpkEndpoints.Services;

namespace RckPprScrLzdSpkEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RckPprScrLzdSpkController : ControllerBase
    {
        private readonly RckPprScrLzdSpkServices _rckPprScrLzdSpkServices;

        public RckPprScrLzdSpkController(RckPprScrLzdSpkServices rckPprScrLzdSpkServices)
        {
            _rckPprScrLzdSpkServices = rckPprScrLzdSpkServices;
        }

        [HttpGet]
        [Route("CpuChoice")]
        public string CpuChoice()
        {
            return _rckPprScrLzdSpkServices.CpuChoice();
        }
    }
}