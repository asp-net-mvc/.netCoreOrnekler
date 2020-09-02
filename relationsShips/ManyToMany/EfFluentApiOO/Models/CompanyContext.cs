using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace EfFluentApiOO.Models
{
    public class CompanyContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<City> City { get; set; }

        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

           modelBuilder.Entity<City>().HasOne(e => e.CityInformation).WithOne(e => e.City).HasForeignKey<City>(e => e.CityInformationId);
        }
    }
}
