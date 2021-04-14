using System.Collections.Generic;

namespace DevIQ.Api.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public List<StoreModel> Stores { get; set; } = new List<StoreModel>();
    }
}