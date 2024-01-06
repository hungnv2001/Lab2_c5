using lab1.Configuation;
using lab2_2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace lab1.Models.Context
{
    public class MyContext : DbContext
    {
        

        public MyContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Lab2,2_c5;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new NhanVienConfiguation());
            modelBuilder.ApplyConfiguration(new ThanNhanConfiguation());

           
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThanNhan> ThanNhans { get; set; }
    }
}
