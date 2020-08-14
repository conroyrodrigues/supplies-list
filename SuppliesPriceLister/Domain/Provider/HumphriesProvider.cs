using buildxact_supplies.Domain.Model.Generic;
using buildxact_supplies.Domain.Model.Humphries;
using buildxact_supplies.Domain.Services;
using buildxact_supplies.Domain.Services.Base;
using buildxact_supplies.Domain.Utility;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace buildxact_supplies.Domain.Provider
{
    public class HumphriesProvider : IHumphriesService
    {
        private readonly string _filePath;
        
        public HumphriesProvider(IConfiguration configuration) 
        {
            _filePath = Path.Combine(FileUtilities.BasePath, configuration.GetSection("humphries").GetSection("assets").Value);
        }
        
        /// <summary>
        /// Humphries uses AUD as the Currency
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Supply> GetPriceInAUD() => FetchFromSource(); 
        
        public IEnumerable<GenericSupplies> GetSupplies()
        {
            return FetchFromSource()
                .Select(z => new GenericSupplies
                {
                    Id = z.Id.ToString(),
                    Description = z.Description,
                    Price = z.Cost
                });
        }
        /// <summary>
        /// Read the CSV File and Generate the Supplies List
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Supply> FetchFromSource()
        {
            return FileReader.ReadCsvFile<Supply>(_filePath);
        }

    }
}
