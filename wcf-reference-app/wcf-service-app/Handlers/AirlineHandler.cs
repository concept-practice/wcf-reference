using System.Collections.Generic;
using wcf_service_app.Models;

namespace wcf_service_app.Handlers
{
    public class AirlineHandler : IAirlineHandler
    {
        private readonly List<Airport> _airports;
        private readonly List<Flight> _flights;

        public AirlineHandler()
        {
            const string airplane = "Boeing 737-8";
            var mci = new Airport("Kansas City", "MCI");
            var iwa = new Airport("Phoenix-Mesa", "IWA");
            var las = new Airport("Las Vegas", "LAS");
            var pit = new Airport("Pittsburgh", "PIT");
            var sfb = new Airport("Orlando-Sanford", "SFB");

            _airports = new List<Airport> {mci, iwa, las, pit, sfb};

            _flights = new List<Flight>
            {
                new Flight(airplane, mci, iwa),
                new Flight(airplane, las, pit),
                new Flight(airplane, sfb, iwa),
                new Flight(airplane, pit, sfb),
                new Flight(airplane, las, mci)
            };
        }

        public IEnumerable<Flight> GetAllFlights() => _flights;

        public IEnumerable<Airport> GetAllAirports() => _airports;
    }
}
