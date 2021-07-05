using System.Collections;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Flights.API.Data
{
    public class FlightContext
    {
        public FlightContext(IConfiguration configuration)
        {
            var connectionString = configuration["MainDB:ConnectionString"];
            var connection = new SqlConnection(connectionString);
            Connection = connection;
            Connection.Open();
        }
        public SqlConnection Connection { get; }
    }
}