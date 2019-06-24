using System;
using Autofac;

namespace wcf_reference_client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = Bootstrapper.Container();

            using (var scope = container.BeginLifetimeScope())
            {
                var flights = scope.Resolve<IFlights>();

                flights.DisplayAirports();
                
                flights.DisplayFlights();
            }


            Console.ReadLine();
        }
    }
}
