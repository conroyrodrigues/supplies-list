using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.IO;

namespace Supplies.Test.Config
{
    
    public static class TestConfiguration
    {
        /// <summary>
        /// Get the path for the data Source
        /// </summary>
        /// <returns></returns>
        public static string GetTestAssetPath() 
        {
            // TODO: A better way to do this, might not work with Linux File Systems
           return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\SuppliesPriceLister"));
        }

        public static Mock<IConfiguration> GetMockConfiguration() 
        {
            var config = new Mock<IConfiguration>();

            config.Setup(x => x.GetSection("megaCorp").GetSection("assets").Value)
                .Returns("Assets\\megacorp.json");

            config.Setup(x => x.GetSection("megaCorp").GetSection("currencyType").Value)
                .Returns("2");

            config.Setup(x => x.GetSection("audUsdExchangeRate").Value)
                .Returns("0.7");

            config.Setup(x => x.GetSection("humphries").GetSection("assets").Value)
                .Returns("Assets\\humphries.csv");

            return config;
        }
    }
}
