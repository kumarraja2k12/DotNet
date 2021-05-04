using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.Customers
{
    public class MembershipType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int SubscriptionAmount { get; set; }
        public int SubscriptionInMonths { get; set; }
        public int Discount { get; set; }
    }
}
