using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Domain.Model.Humphries
{
    public class Supply
    {
        [Index(0)]
        public Guid Id { set; get; }

        [Index(1)]
        public string Description { set; get; }

        [Index(2)]
        public string Unit { set; get; }

        [Index(3)]
        public decimal Cost { set; get; }
    }
}
