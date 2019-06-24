using System.ServiceModel;
using Autofac;
using Autofac.Integration.Wcf;
using wcf_reference_client.FlightServiceReference;

namespace wcf_reference_client
{
    public static class Bootstrapper
    {
        public static IContainer Container()
        {
            var builder = new ContainerBuilder();

            builder.Register(c => new ChannelFactory<IFlightService>("BasicHttpBinding_IFlightService")).SingleInstance();

            builder.Register(c => c.Resolve<ChannelFactory<IFlightService>>().CreateChannel())
                .As<IFlightService>()
                .UseWcfSafeRelease();

            builder.RegisterType<Flights>().As<IFlights>();

            return builder.Build();
        }
    }
}
