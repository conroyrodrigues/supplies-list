using buildxact_supplies.Domain.Provider;
using buildxact_supplies.Domain.Services;
using buildxact_supplies.Domain.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supplies.Test.Config;
using System.Linq;

namespace Supplies.Test.Provider
{
    [TestClass]
    public class SuppliesProviderTest
    {
        private ISuppliesService _suppliesservice;
        private IHumphriesService _humphriesService;
        private IMegaCorpService _megaCorpService;

        [TestInitialize]
        public void Initialize() 
        {
            FileUtilities.BasePath = TestConfiguration.GetTestAssetPath();

            var config = TestConfiguration.GetMockConfiguration();

            _humphriesService = new HumphriesProvider(config.Object); ;
                
            _megaCorpService = new MegaCorpProvider(config.Object);

            _suppliesservice = new SuppliesProvider(_megaCorpService, _humphriesService);

        }
        [TestMethod]
        public void Has_OrderedBy_Descending_Prices_Supplies() 
        {
            // Arrange
            var records = _suppliesservice.GetSupplies().ToList();
            var topMostPrice = records.Select(z => z.Price).First();
            var lastPrice = records.Select(z => z.Price).Last();
            // Act
            var isValid = topMostPrice > lastPrice;
            //Assert
            Assert.IsTrue(isValid);
        }

        
    }
}
