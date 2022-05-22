using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMapping.Orm.Entity.EntitySpliting
{
    //ENtity Spliting
    /*User için tek bir tablo oluşturmak yerine 2 tabloya ayıracağız. Tablolardan birisinde 
     kullanıcı hakkında bağlantı bilgilerini tutarken diğerinde hesap bilgilerini tutuyor olacağız. Bunu "ProjeContext" içerisinde
    "OnModelCreating" methodunu override ederek sağlayacağız. Bu düzenleme 1'e 1 bağlanmış 2 tablo oluşturmuş olacak. Fakat C#
    tarafında
    */
    public class AppUser
    {
        public int Id { get; set; }

        public string  UserName { get; set; }

        public string Password { get; set; }

        public string ContactNumber { get; set; }

        public string Adress { get; set; }
    }
}
