using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Domain.Utility
{
    public static class PriceConverter
    {
        public static decimal GetConvertedPrice(decimal price, decimal exchangeRate) => price * exchangeRate;
    }
}
