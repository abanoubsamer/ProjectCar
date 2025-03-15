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
    public class UserPhoneConfig : IEntityTypeConfiguration<UserPhoneNumber>
    {
        public void Configure(EntityTypeBuilder<UserPhoneNumber> builder)
        {
            builder.Property(x => x.PhoneNumber).HasDefaultValueSql("NEWID()");



        }
    }
}
