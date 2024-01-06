using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using lab1.Models;
using lab2_2.Model;

namespace lab1.Configuation
{
    public class NhanVienConfiguation : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");

            builder.HasKey(x => x.MaNV);
            builder.Property(x => x.Honv).HasColumnType("nvarchar").HasMaxLength(15);
            builder.Property(x => x.TenLot).HasColumnType("nvarchar").HasMaxLength(15);
            builder.Property(x => x.TenNV).HasColumnType("nvarchar").HasMaxLength(15);
            builder.Property(x => x.DChi).HasColumnType("nchar").HasMaxLength(30);
            builder.Property(x => x.Phai).HasColumnType("nchar").HasMaxLength(3);
            builder.Property(x => x.MaNV).HasColumnType("char").HasMaxLength(9);
            builder.Property(x => x.MaNQL).HasColumnType("char").HasMaxLength(9).IsRequired(false);
            builder.Property(x => x.PHG).IsRequired();
            builder.Property(x => x.Luong).HasColumnType("float");
            builder.Property(x => x.NgaySinh).HasColumnType("datetime");


        }
    }
}