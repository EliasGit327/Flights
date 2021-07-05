using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Flights.API.Data;

namespace Flights.API.Repositories
{
    public class FlightRepository
    {
        private readonly FlightContext _flightContext;
        private readonly SqlConnection _connection;
        
        public FlightRepository(FlightContext flightContext)
        {
            _flightContext = flightContext;
            _connection = flightContext.Connection;
        }
        
        public IEnumerable<Flight> GetFlights()
        {
            var queryString = "SELECT * FROM dbo.Flight;";
            var command = new SqlCommand(queryString, _connection);
            using var reader = command.ExecuteReader();
            var result = new List<Flight>();
            while (reader.Read())
            {
                var flight = new Flight()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Author = reader.GetString(2),
                    Isbn = reader.GetString(3)
                };
                result.Add(flight);
            }
            return result;
        }
        
    }
}