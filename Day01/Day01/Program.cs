using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace Day01
{
    class Program
    {
        static Task Main(string[] args)
        {
            using var host = CreateHostBuilder(args);
            return host.RunAsync();
        }

        private static IHost CreateHostBuilder(string[] args)
        {
            var defaultBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureServices((hbContext, services) => services.AddHostedService<Worker>())
                .Build();
            return defaultBuilder;
        }
    }
}
