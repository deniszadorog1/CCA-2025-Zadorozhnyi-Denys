using Microsoft.Extensions.DependencyInjection;
using Task3.Interfaces;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<IDataProvider, DatabaseService>();
            services.AddTransient<ILogger, FileLogger>();
            services.AddTransient<ReportGenerator>();

            var provider = services.BuildServiceProvider();
            var generator = provider.GetRequiredService<ReportGenerator>();
            generator.Generate();
        }
    }
}
