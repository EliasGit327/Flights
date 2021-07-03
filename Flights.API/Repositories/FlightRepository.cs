using System.Collections.Generic;
using Flights.API.Data;

namespace Flights.API.Repositories
{
    public class FlightRepository: IFlightRepository
    {
        private readonly IFlightContext _flightContext;
        
        public FlightRepository(IFlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        
        public string Test()
        {
            return _flightContext.Connection;
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