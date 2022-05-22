using EfMapping.Orm.Entity.CompositeKey;
using EfMapping.Orm.Entity.ConditionalMapping;
using EfMapping.Orm.Entity.EntitySpliting;
using EfMapping.Orm.Entity.ManyToMany;
using EfMapping.Orm.Entity.TableSpliting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMapping.Orm.Context
{
    public class ProjeContext : DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-AK0MLSE8; Database=TESTMappingg; integrated security=True; MultipleActiveResultSets=True;";
        }

        public DbSet<Teacher> Teachers { get; set; } //ManyToMany

        public DbSet<Student> Students { get; set; } //ManyToMany

        public DbSet<Employee> Employees { get; set; }

        public DbSet<CompositeKeyTable> compositeKeyTables { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Conditional Mapping

            modelBuilder.Entity<Product>()
                .Map(m => m.Requires("isOnSale")
                .HasValue(true))
                .Ignore(m => m.IsOnSale);


            modelBuilder.Entity<Category>()
                .Map(z => z.Requires("CategoryName")
                .HasValue("Icecek"))
                .Ignore(t => t.CategoryName);


            //Tablo isimlerinin otomatik çoğul olmasını engelleyecek kod.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();



            //EntitySpliting

            modelBuilder.Entity<AppUser>().Map(map =>
            {
                map.Properties(z => new
                {
                    z.Id,
                    z.UserName,
                    z.Password
                });
                map.ToTable("UserAccountInfo");

            }).Map(map =>
            {
                map.Properties(u => new
                {
                    u.Id,
                    u.ContactNumber,
                    u.Adress
                });
                map.ToTable("UserContactDetail");
            });

            //Table Spliting

            modelBuilder.Entity<Employee>().HasKey(x => x.EmployeeId).ToTable("Employees");

            modelBuilder.Entity<EmployeeContactDetail>().HasKey(z => z.EmployeeId).ToTable("Employees");

            modelBuilder.Entity<Employee>().HasRequired(x => x.employeeContactDetail).WithRequiredPrincipal(y => y.Employee);



            //Many to many 

            modelBuilder.Entity<Teacher>().HasMany(t => t.Students).WithMany(t => t.Teachers).Map(map =>
           {
               map.ToTable("TeachersStudents");
               map.MapLeftKey("TeacherId");
               map.MapRightKey("StudentId");
           });




            base.OnModelCreating(modelBuilder);
        }
    }
}
