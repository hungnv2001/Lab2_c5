using lab1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab1.Configuation
{
    public class ClientConfiguation : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("tblClient");

            builder.HasKey(x => x.clientName);

            builder.Property(x => x.PhoName).IsRequired(true).HasMaxLength(10);
            builder.Property(x => x.clientName).HasMaxLength(50);
            builder.HasOne(x => x.Address).WithMany(x => x.Clients).HasForeignKey(x => x.AddressID);
        }
    }
}