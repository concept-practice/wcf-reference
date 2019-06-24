using System;
using Autofac;
using Autofac.Integration.Wcf;
using wcf_service_app.Handlers;

namespace wcf_service_app
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AirlineHandler>().As<IAirlineHandler>();

            builder.RegisterType<FlightService>().As<IFlightService>();

            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }
    }
}