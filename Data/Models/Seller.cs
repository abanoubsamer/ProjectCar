using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Seller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string SellerID { get; set; }

        public string ShopName { get; set; }

        public string Type { get; set; }

        public string ContactInfo { get; set; }

        public string country { get; set; }

        // Relationship with User

        public string UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public virtual User user { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
