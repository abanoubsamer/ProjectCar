using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ShippingAddress
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AddressID { get; set; }

        public string UserId { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual User user { get; set; }

        public string Country { get; set; }
        public string Street { get; set; }
        public string  City { get; set; }
    }
}
