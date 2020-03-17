using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TC.Service.Infrastructure;
using TC.Model;
using TC.Context;
using Microsoft.EntityFrameworkCore;
using Prism.Services;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace TC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ActivatorUtilitiesConstructor]
    public class VanBanDenConTroller : ControllerBase
    {
        private readonly ITCVanBanDen _context;
        public VanBanDenConTroller(ITCVanBanDen context)       
        {
            _context = context;
        }
        
        public IDependencyService Service { get; set; }
       
        [HttpGet]
        public ActionResult<IEnumerable<VanBanDens>> Get()
        {
            return _context.GetVanBanDen();
        }

        [HttpGet("{id}")]
       public ActionResult<string> Get(int id)
        {
            return "vanbanden";
        }

        private readonly ILogger<VanBanDenConTroller> _logger;

        public VanBanDenConTroller(ILogger<VanBanDenConTroller> logger)
        {
            _logger = logger;
        }

       


       
        
       

       
    }
}
