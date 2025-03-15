using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DbConfigration
{
    public class Paymentconfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {

            builder.Property(x => x.PaymentID).HasDefaultValueSql("NEWID()");
            builder.HasOne(x => x.Order).WithOne(x => x.Payment).HasForeignKey<Payment>(x => new {x.OrderID, x.PaymentID});
            
        }
    }
    
}
