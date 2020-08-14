namespace buildxact_supplies.Domain.Utility
{
    public static class PriceConverter
    {
        /// <summary>
        /// Get Converted Price based on the exchangerate
        /// </summary>
        /// <param name="price"></param>
        /// <param name="exchangeRate"></param>
        /// <returns></returns>
        public static decimal GetConvertedPrice(decimal price, decimal exchangeRate) => price * exchangeRate;
    }
}
