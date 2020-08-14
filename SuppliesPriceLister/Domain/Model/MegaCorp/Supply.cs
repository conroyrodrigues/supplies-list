using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Domain.Model.MegaCorp
{
    public class Supply
    {
        [JsonProperty("id")]
        public int SuppliesId { set; get; }

        [JsonProperty("description")]
        public string Description { set; get; }

        [JsonProperty("uom")]
        public string UnitOfMeasure { set; get; }

        [JsonProperty("priceInCents")]
        public decimal PriceInCents {set;get;}

        [JsonProperty("providerId")]
        public Guid ProviderId { set; get; }

        [JsonProperty("materialType")]
        public string MaterialType { set; get; }

        // Derived Types from JSON File
        public decimal PriceInAUD { set; get; }
        public decimal PriceInDollar 
        {
            set => PriceInCents = value;
            get => (PriceInCents / 100);
        }
    }
}
