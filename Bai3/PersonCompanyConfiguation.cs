using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    internal class PersonCompanyConfiguation : IEntityTypeConfiguration<PersonCompany>
    {
        public void Configure(EntityTypeBuilder<PersonCompany> builder)
        {
            builder.HasOne(x => x.People).WithMany(p => p.PersonCompany).HasForeignKey(x => x.Person_Id);
            builder.HasOne(x => x.Company).WithMany(p => p.PersonCompany).HasForeignKey(x => x.Company_Id);
            builder.Property(x => x.Curent).HasColumnName($"[Curent]");
        }
    }
}
