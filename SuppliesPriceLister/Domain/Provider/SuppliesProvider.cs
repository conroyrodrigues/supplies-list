using buildxact_supplies.Domain.Model.Generic;
using buildxact_supplies.Domain.Services;
using System.Collections.Generic;
using System.Linq;

namespace buildxact_supplies.Domain.Provider
{
    public class SuppliesProvider : ISuppliesService
    {
        private IMegaCorpService _megaCorpService;
        private IHumphriesService _humphriesService;
        
        public SuppliesProvider(IMegaCorpService megaCorpService, IHumphriesService humphriesService) 
        {
            _megaCorpService = megaCorpService;
            _humphriesService = humphriesService;
        }
        public IEnumerable<GenericSupplies> GetSupplies()
        {
            var allSupplies = new List<GenericSupplies>();
            // Get Humphries Supplies
            allSupplies.AddRange(_humphriesService.GetSupplies());
            // Get Mega Corp Supplies
            allSupplies.AddRange(_megaCorpService.GetSupplies());
            // Get the compiled List With Highest Price First
            return allSupplies.OrderByDescending(z=> z.Price);
        }
        
    }
}
