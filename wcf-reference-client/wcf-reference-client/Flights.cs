using System;
using wcf_reference_client.FlightServiceReference;

namespace wcf_reference_client
{
    public class Flights : IFlights
    {
        private readonly IFlightService _flightServiceClient;

        public Flights(IFlightService flightServiceClient) => _flightServiceClient = flightServiceClient;


        public void DisplayFlights()
        {
            var flights = _flightServiceClient.GetAllFlights();

            foreach(var i in flights) DisplayFlight(i);
        }

        public void DisplayAirports()
        {
            var airports = _flightServiceClient.GetAllAirports();

            foreach (var i in airports) DisplayAirport(i);
        }

        private void DisplayAirport(Airport airport)
        {
            Console.WriteLine(airport.Id);
            Console.WriteLine(airport.Name);
            Console.WriteLine(airport.Iata);
            Console.WriteLine();
        }

        private void DisplayFlight(Flight flight)
        {
            Console.WriteLine(flight.Id);
            Console.WriteLine(flight.Airplane);
            DisplayAirport(flight.Departure);
            DisplayAirport(flight.Arrival);
            Console.WriteLine();
        }
    }
}
