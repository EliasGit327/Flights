using System.Collections;
using Microsoft.Extensions.Configuration;

namespace Flights.API.Data
{
    public class FlightContext: IFlightContext
    {
        public FlightContext(IConfiguration configuration)
        {
            Connection = configuration["MainDB:ConnectionString"];
        }
        public string Connection { get; }
    }
}