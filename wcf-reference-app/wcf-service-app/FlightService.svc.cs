using System.Collections.Generic;
using wcf_service_app.Handlers;
using wcf_service_app.Models;

namespace wcf_service_app
{
    public class FlightService : IFlightService
    {
        private readonly IAirlineHandler _airlineHandler;

        public FlightService(IAirlineHandler airlineHandler) => _airlineHandler = airlineHandler;

        public IEnumerable<Flight> GetAllFlights() => _airlineHandler.GetAllFlights();

        public IEnumerable<Airport> GetAllAirports() => _airlineHandler.GetAllAirports();
    }
}
