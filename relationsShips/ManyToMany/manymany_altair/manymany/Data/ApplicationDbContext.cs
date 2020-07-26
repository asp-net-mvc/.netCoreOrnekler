using manymany.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace manymany.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Supplier> supplier { get; set; }

        public DbSet<Customer> customer { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        private static ILoggerFactory dbLoggerCategory =
        LoggerFactory.Create(builder =>
        {
            builder.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information).AddConsole();
        });


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer("Server=.; Database=BlogDb; User Id=sa; Password=*******");
            optionsBuilder.UseLoggerFactory(dbLoggerCategory);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CustomerSupplier>()
                .HasKey(t => new { t.customerId, t.suplierId });

            builder.Entity<CustomerSupplier>()
                .HasOne(p => p.customer)
                .WithMany(x => x.supplier)
                .HasForeignKey(y => y.customerId);

            builder.Entity<CustomerSupplier>()
                .HasOne(p => p.suplier)
                .WithMany(x => x.customer)
                .HasForeignKey(y => y.suplierId);




            /*
             
            //bununla çözülür 

             //diğer map yonetemi 
             //https://www.tektutorialshub.com/entity-framework/ef-many-many-relationship/

                        builder.Entity<Employee>()
                           .HasMany(e => e.Projects)
                           .WithMany(e => e.Employees)
                           .Map(m =>
                           {
                               m.ToTable("EmployeesInProject");
                               m.MapLeftKey("EmployeeID");
                               m.MapRightKey("ProjectID");
                           }
                );
            */
            //https://www.codeproject.com/Articles/234606/Creating-a-Many-To-Many-Mapping-Using-Code-First

        }
    }
}
