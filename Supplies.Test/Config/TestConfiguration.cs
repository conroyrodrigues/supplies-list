using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.IO;

namespace Supplies.Test.Config
{
    
    public static class TestConfiguration
    {
        public static string GetTestAssetPath() 
        {
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
