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
        private FlightService _flightService;
        
        public FlightsController(ILogger<FlightsController> logger, FlightService flightService)
        {
            _logger = logger;
            _flightService = flightService;
        }

        [HttpGet]
        public ActionResult GetFlights()
        {
            var result = _flightService.GetFlights();
            return Ok(result);
        }
    }
}
