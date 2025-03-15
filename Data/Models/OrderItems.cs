using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    [PrimaryKey(nameof(OrderID), nameof(ProductID))]
    public class OrderItems
    {
        [Required]
        public string OrderID { get; set; }
        public virtual Order Order { get; set; }

      
        [Required]
        public string ProductID { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public OrderItemStatus Status { get; set; }

        [Required]
        public string SellerID { get; set; }
        [ForeignKey(nameof(SellerID))]
        public virtual Seller Seller { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
