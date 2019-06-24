using System;
using System.Runtime.Serialization;

namespace wcf_service_app.Models
{
    [DataContract]
    public class Airport
    {
        [DataMember]
        public Guid Id { get; private set; }

        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public string Iata { get; private set; }

        public Airport(string name, string iata)
        {
            Id = Guid.NewGuid();
            Name = name;
            Iata = iata;
        }
    }
}
