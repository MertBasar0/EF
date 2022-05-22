using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRepo.DAL.ORM.Entity
{
    //Table Attribute içerisinde yazılmış olan string değeri tablo oluşturulurken tablo ismi olarak belirlensin istiyorsanız.
    
    [Table("Users")]
    public class AppUser : BaseEntity
    {
        //MaxLength default olarak nvarchar(max) olan stringleri belirten sayı kadar yer alabileceğini belirtir.

        [MaxLength(30)]
        public string LastName { get; set; } // max=30


        [NotMapped]
        //NotMapped entity içerisinde var olmasına rağmen database'de tabloda bir sütun olarak oluşturulmayacaktır.

        public string FullName 
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return Name;
                }
                else
                {
                    return Name + " " + LastName; // Buradaki name prop BaseEntity den gelecek ayarlanacak.
                }
            }
        } 
        
          // LastName kolonu içerisine girilen değerde boşluk kontrolü sağlayın eğer
          // boşluk yok direk name bilgisini döndürün, boşluk var ise isim+soyisim
          // bilgisini döndürsün.

        [Required]
        //Referance Type olmasına rağmen Required yazarak "Not Null" bir sütun oluşturulabilir.
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }

        public DateTime Birt_Date { get; set; }

        public bool Gender { get; set; }

    }
}
