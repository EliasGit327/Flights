using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Flights.API.Data;
using Flights.API.Repositories;
using Flights.API.Services;
using Microsoft.Extensions.Configuration;

namespace Flights.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly ILogger<FlightsController> _logger;
        private IFlightService _flightService;
        
        public FlightsController(ILogger<FlightsController> logger, IFlightService flightService)
        {
            _logger = logger;
            _flightService = flightService;
        }

        [HttpGet("GetString")]
        public ActionResult<string> GetString()
        {
            return Ok(_flightService.Test());
        }
    }
}
