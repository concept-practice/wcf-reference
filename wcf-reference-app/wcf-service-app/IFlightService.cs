using System.Collections.Generic;
using System.ServiceModel;
using wcf_service_app.Models;

namespace wcf_service_app
{
    [ServiceContract]
    public interface IFlightService
    {
        [OperationContract]
        IEnumerable<Flight> GetAllFlights();

        [OperationContract]
        IEnumerable<Airport> GetAllAirports();
    }
}
