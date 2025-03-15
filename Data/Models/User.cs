using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User : IdentityUser
    {

        [Required]
        public string Name { get; set; }

        public string? Picture { get; set; }

        public string? SellerID { get; set; } // Nullable property to allow optional seller

        [ForeignKey(nameof(SellerID))]
        public virtual Seller? Seller { get; set; }

        [ForeignKey(nameof(Cart))]
         public virtual Cart cart { get; set; }

        public DateTime DateCreate { get; set; } = DateTime.Now;

        public virtual ICollection<ShippingAddress> ShippingAddresses { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<UserPhoneNumber> PhoneNumbers { get; set; } = new List<UserPhoneNumber>();

        //[NotMapped] // نمنع EF من إضافته في الداتا بيز
        //public override string PhoneNumber { get => null; set { } }

    }
}
