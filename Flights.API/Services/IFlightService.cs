using System.Collections.Generic;

namespace Flights.API.Services
{
    public interface IFlightService
    {
        public string Test();
        public IEnumerable<string> GetLastFlights();
        public string GetConcreteFlight(int id);
        public bool AddAFlight(string flight);   
    }
}