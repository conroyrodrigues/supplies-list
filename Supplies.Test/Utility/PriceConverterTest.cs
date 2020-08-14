using buildxact_supplies.Domain.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Supplies.Test.Utility
{
    [TestClass]
    public class PriceConverterTest
    {
        [TestMethod]
        public void Is_Valid_Conversion()
        {
            // Arrage
            var price = 200;
            var exchangeRate = 0.7m;
            var expectedOutput = 140.0m;
            // Act
            var converterValue = PriceConverter.GetConvertedPrice(price, exchangeRate);
            // Assert
            Assert.AreEqual(converterValue, expectedOutput);
        }

        [TestMethod]
        public void Is_Not_A_Valid_Conversion()
        {
            // Arrage
            var price = 200;
            var exchangeRate = 0.7m;
            var expectedOutput = 200.0m;
            // Act
            var converterValue = PriceConverter.GetConvertedPrice(price, exchangeRate);
            // Assert
            Assert.AreNotEqual(converterValue, expectedOutput);
        }
    }
}
