using buildxact_supplies.Domain.Provider;
using buildxact_supplies.Domain.Services;
using buildxact_supplies.Domain.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supplies.Test.Config;
using System.Linq;

namespace Supplies.Test.Provider
{
    [TestClass]
    public class HumphriesProviderTest
    {
        private IHumphriesService _humphriesService;

        [TestInitialize]
        public void Innitialize()
        {
            FileUtilities.BasePath = TestConfiguration.GetTestAssetPath();

            var config = TestConfiguration.GetMockConfiguration();

            _humphriesService = new HumphriesProvider(config.Object);
        }

        [TestMethod]
        public void Has_Supplies_Price_In_AUD()
        {
            //Arrange
            var records = _humphriesService.GetPriceInAUD();
            //Act
            var hasValidRecords = records.Any();
            //Asserts
            Assert.IsTrue(hasValidRecords);
        }

        [TestMethod]
        public void Has_Parsed_Generic_Supplies()
        {
            //Arrange
            var suppliedWithAudPrice = _humphriesService.GetPriceInAUD();
            var genericSuppliesList = _humphriesService.GetSupplies();

            //ACT
            var hasSameNumberOfRecords = suppliedWithAudPrice.Count() == genericSuppliesList.Count();

            //Assert
            Assert.IsTrue(hasSameNumberOfRecords);
        }

    }
}
