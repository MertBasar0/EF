using CodeFirstRepo.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRepo.DAL.ORM.Context
{
    public class TestContext : DbContext
    { 
        /* 
        1) NUget Package Manager ile Entity Framework projeye eklenir.
        2) Orm Klasörü altında => context ve entity şeklinde bir yapılanmaya gidin.
        3) Entity klasörü altına tablo olarak kullanılacak classlarını yaz.
        4) Connection string'i entityFramework base'i ne yolladık. Bundan connection string app config dosyası içerisine yazıp ordan çektik.
        5) Sizin kendi yazmış olduğunuz context sınıfına dbcontext sınıfından miras vermeniz lazım.
        6) Tablo olmasını istediğiniz class'lar "Public sbset<entity> entities {get; set;}" formatında yazılır.
        Örn: Public dbset<product> products {get; set;}

        7) Nuget Console açılarak "Enable-migrations" configurations dosyasında elle true çekmekle uğraşmak istemiyorsanız "enable-migrations-enableAutomaticMigrations" yazılması gerekir.
        8) update-database ile yapılan db işlemlerinin database de gerçekleşmesini sağlayabilirsiniz.
         
         */
        public TestContext()
        {
            Database.Connection.ConnectionString = "server=LAPTOP-AK0MLSE8;initial catalog=test4;integrated security=True;";
        }


        public DbSet<AppUser> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
