using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ReviewID { get; set; }


        public string UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public virtual User user { get; set; }

        public string ProductID { get; set; }
        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; }


        public string Comment { get; set; }


        public DateTime ReviewDate { get; set; } = DateTime.Now;
    }
}
