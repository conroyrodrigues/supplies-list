using buildxact_supplies.Domain.Model.Generic;
using System.Collections.Generic;

namespace buildxact_supplies.Domain.Services
{
    public interface ISuppliesService
    {
        IEnumerable<GenericSupplies> GetSupplies();
    }
}
