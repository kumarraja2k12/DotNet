using System.Collections.Generic;
using Vidly.Models.Customers;

namespace Vidly.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }
    }
}
