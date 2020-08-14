using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Domain.Model.MegaCorp
{
    public class Partner
    {
        [JsonProperty("name")]
        public string Name { set; get; }

        [JsonProperty("partnerType")]
        public string PartnerType { set; get; }

        [JsonProperty("partnerAddress")]
        public string PartnerAddress { set; get; }

        [JsonProperty("supplies")]
        public Supply[] Supplies { set; get; }
    }
}
