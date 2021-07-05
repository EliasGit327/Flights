using System.Collections.Generic;
using Flights.API.Data;
using Flights.API.Repositories;

namespace Flights.API.Services
{
    public class FlightService
    {
        private readonly FlightRepository _flightRepository;

        public FlightService(FlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public object GetFlights()
        {
            var result = _flightRepository.GetFlights();
            return result;
        }
    }
}