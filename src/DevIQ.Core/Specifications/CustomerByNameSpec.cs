using Ardalis.Specification;
using DevIQ.Core.Entities;
namespace DevIQ.Core.Specifications
{
    public class CustomerByNameSpec : Specification<Customer>, ISingleResultSpecification
    {
        public CustomerByNameSpec(string name)
        {
            Query.Where(x => x.Name == name)
                 .OrderBy(x => x.Name)
                    .ThenByDescending(x => x.Address);
        }
    }
}