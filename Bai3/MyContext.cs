

using Lab2_3;
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
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=Lab2,3_c5;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
           modelBuilder.ApplyConfiguration(new PersonCompanyConfiguation());


           
        }
        public DbSet<PersonCompany> PersonCompanies { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
