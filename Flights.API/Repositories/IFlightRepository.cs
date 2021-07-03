using System.Collections;
using System.Collections.Generic;

namespace Flights.API.Repositories
{
    public interface IFlightRepository
    {
        public string Test();
        public IEnumerable<string> GetLastFlights();
        public string GetConcreteFlight(int id);
        public bool AddAFlight(string flight);
    }
}