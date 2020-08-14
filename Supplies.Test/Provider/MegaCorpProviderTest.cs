using buildxact_supplies.Domain.Provider;
using buildxact_supplies.Domain.Services;
using buildxact_supplies.Domain.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supplies.Test.Config;
using System.Linq;

namespace Supplies.Test.Provider
{
    [TestClass]
    public class MegaCorpProviderTest
    {
        private IMegaCorpService _megaCorpService;

        [TestInitialize]
        public void Innitialize()
        {
            FileUtilities.BasePath = TestConfiguration.GetTestAssetPath();

            var config = TestConfiguration.GetMockConfiguration();

            _megaCorpService = new MegaCorpProvider(config.Object);
        }

        [TestMethod]
        public void Can_Fetch_Resources()
        {
            //Arrange
            var records = _megaCorpService.FetchFromSource();
            //Act
            var hasValidRecords = records.Any();
            //Asserts
            Assert.IsTrue(hasValidRecords);
        }

        
        [TestMethod]
        public void Has_Parsed_Generic_Supplies()
        {
            //Arrange
            var suppliedWithAudPrice = _megaCorpService.GetPriceInAUD();
            var genericSuppliesList = _megaCorpService.GetSupplies();

            //ACT
            var hasSameNumberOfRecords = suppliedWithAudPrice.Count() == genericSuppliesList.Count();

            //Assert
            Assert.IsTrue(hasSameNumberOfRecords);

        }
    }
}
