using Autofac;
using Autofac.Extensions.DependencyInjection;
using Med.Infrastructure.CrossCutting.IOC;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MedicationAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureContainer<ContainerBuilder>(builder =>
            builder.RegisterModule(new ModuleIOC()))
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
