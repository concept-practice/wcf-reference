using System.Collections.Generic;
using wcf_service_app.Models;

namespace wcf_service_app.Handlers
{
    public interface IAirlineHandler
    {
        IEnumerable<Flight> GetAllFlights();
        IEnumerable<Airport> GetAllAirports();
    }
}
