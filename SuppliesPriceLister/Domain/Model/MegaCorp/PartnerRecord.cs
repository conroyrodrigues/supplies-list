using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Domain.Model.MegaCorp
{
    public class PartnerRecord
    {
        [JsonProperty("partners")]
        public List<Partner> Partners { set; get; }
    }
}
