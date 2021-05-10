﻿using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.Customers
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }
    }
}
