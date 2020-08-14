using Microsoft.Extensions.DependencyInjection;
using buildxact_supplies.Domain.Services;
using buildxact_supplies.Domain.Provider;
using System;
using Microsoft.Extensions.Configuration;
using ConsoleTables;
using System.Linq;
using System.Globalization;

namespace SuppliesPriceLister
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build the configuration for the project
            var configuration = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json", true, true)
                                .Build();
            // Inject the Dependemcies require by each service
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConfiguration>(configuration)
                .AddSingleton<ISuppliesService, SuppliesProvider>()
                .AddSingleton<IMegaCorpService, MegaCorpProvider>()
                .AddSingleton<IHumphriesService, HumphriesProvider>()
                .BuildServiceProvider();

            // Fetch A Compiled list of the Supplies
            var supplies = serviceProvider
                    .GetService<ISuppliesService>()
                    .GetSupplies()
                    .ToList();

            // Create a Table For Presentation
            var table = new ConsoleTable("Id", "Description", "Price(AUD)", "Rounded(AUD)");
            
            supplies.ForEach(s =>
                table.AddRow(s.Id,
                    s.Description,
                    s.Price.ToString("C", CultureInfo.CurrentCulture),
                    Math.Round(s.Price).ToString("C", CultureInfo.CurrentCulture)));

            // Write the table on the console
            table.Write();
            Console.ReadLine();
        }
    }
}
