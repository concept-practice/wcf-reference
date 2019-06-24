using System;
using System.Runtime.Serialization;

namespace wcf_service_app.Models
{
    [DataContract]
    public class Flight
    {
        [DataMember]
        public Guid Id { get; private set; }

        [DataMember]
        public string Airplane { get; private set; }

        [DataMember]
        public Airport Departure { get; private set; }

        [DataMember]
        public Airport Arrival { get; private set; }

        public Flight(string airplane, Airport departure, Airport arrival)
        {
            Id = Guid.NewGuid();
            Airplane = airplane;
            Departure = departure;
            Arrival = arrival;
        }
    }
}
