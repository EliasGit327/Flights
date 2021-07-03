using System.Collections.Generic;
using Flights.API.Data;
using Flights.API.Repositories;

namespace Flights.API.Services
{
    public class FlightService: IFlightService
    {
        private readonly IFlightRepository _flightRepository;

        public FlightService(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }
        
        public string Test()
        {
            return _flightRepository.Test();
        }

        public IEnumerable<string> GetLastFlights()
        {
            throw new System.NotImplementedException();
        }

        public string GetConcreteFlight(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool AddAFlight(string flight)
        {
            throw new System.NotImplementedException();
        }
    }
}