using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using lab1.Models;
using lab2_2.Model;

namespace lab1.Configuation
{
    public class ThanNhanConfiguation : IEntityTypeConfiguration<ThanNhan>
    {
        public void Configure(EntityTypeBuilder<ThanNhan> builder)
        {
            builder.ToTable("ThanNhan");
            builder.Property(x => x.TenTN).HasColumnType("nvarchar").HasMaxLength(15);
            builder.HasKey(x => new { x.Ma_NV, x.TenTN });
            builder.HasOne(p=>p.NhanVien).WithMany(p=>p.thanNhans).HasForeignKey(p=>p.Ma_NV);
            builder.Property(x => x.Phai).HasColumnType("char").HasMaxLength(3);
            builder.Property(x => x.Ma_NV).HasColumnType("char").HasMaxLength(9);
            builder.Property(x => x.NgSinh).HasColumnType("datetime");
           
            builder.Property(x => x.QuanHe).HasColumnType("nvarchar").HasMaxLength(15);


        }
    }
}