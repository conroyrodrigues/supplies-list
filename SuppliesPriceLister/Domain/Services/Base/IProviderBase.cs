using buildxact_supplies.Domain.Model.Generic;
using System.Collections.Generic;

namespace buildxact_supplies.Domain.Services.Base
{
    public interface IProviderBase<T>
    {
        IEnumerable<T> GetPriceInAUD();

        IEnumerable<T> FetchFromSource();

        IEnumerable<GenericSupplies> GetSupplies();
    }
}
