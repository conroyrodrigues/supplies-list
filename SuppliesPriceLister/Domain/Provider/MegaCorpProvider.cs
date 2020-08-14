using buildxact_supplies.Domain.Enums.GenericType;
using buildxact_supplies.Domain.Model.Generic;
using buildxact_supplies.Domain.Model.MegaCorp;
using buildxact_supplies.Domain.Services;
using buildxact_supplies.Domain.Utility;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Supply = buildxact_supplies.Domain.Model.MegaCorp.Supply;

namespace buildxact_supplies.Domain.Provider
{
    public class MegaCorpProvider : IMegaCorpService
    {
        private decimal _conversionRate;
        private readonly string _filePath;
        private CurrencyType _currencyType;
        public MegaCorpProvider(IConfiguration configuration)
        {
            // Retrive Settings from appsettings
            _filePath = Path.Combine(FileUtilities.BasePath, 
                                    configuration.GetSection("megaCorp").GetSection("assets").Value); 

            this._conversionRate = Convert.ToDecimal(configuration["audUsdExchangeRate"]);
            
            // Set the default currency fo this Provider
            _currencyType = (CurrencyType) Enum.Parse(typeof(CurrencyType), configuration.GetSection("megaCorp").GetSection("currencyType").Value);
        }

        
        /// <summary>
        /// Get the Supplies converting the Price into AUD given the exchange rate
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Supply> GetPriceInAUD()
        {
            if (!File.Exists(_filePath)) return new List<Supply>();

            var requiresConversion = _currencyType != CurrencyType.AUD;

            var suppliesFromSource =  FetchFromSource();

            if (requiresConversion) 
            {
                // You cant perform Calculation on an IEnumerable (properties are Readonly) 
                // pull it in memory only if there is a conversion required.
                suppliesFromSource = suppliesFromSource.ToList();

                foreach (var supply in suppliesFromSource) {
                    
                    supply.PriceInAUD = PriceConverter
                                        .GetConvertedPrice(supply.PriceInDollar, _conversionRate);
                }
            }
           
            return suppliesFromSource;
        }

       
        /// <summary>
        /// Read from Raw Json File, using the provided Path
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Supply> FetchFromSource()
        {
            return FileReader
                .ReadJsonFile<PartnerRecord>(_filePath)
                .SelectMany(z => z.Partners.SelectMany(a => a.Supplies));
        }

        public IEnumerable<GenericSupplies> GetSupplies()
        {
            return GetPriceInAUD()
                .Select(z => new GenericSupplies
                {
                    Id = z.SuppliesId.ToString(),
                    Description = z.Description,
                    Price = z.PriceInAUD
                }); 
        }
    }
}
