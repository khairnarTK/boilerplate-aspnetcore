using System;
namespace DevIQ.Api.Models
{
    public class CustomerFilterModel : BaseFilterModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
