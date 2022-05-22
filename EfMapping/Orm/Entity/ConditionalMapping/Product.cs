using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMapping.Orm.Entity.ConditionalMapping
{
    //Conditional Mapping

    //Proje Context içerisinde "OnModelCreating" override ederek mapping esnasında "isOnSale" sütunu üzerinde bir koşul belirlenecek.
    //Bu koşul ile ürün listesi getirilirken isonsale - false olan kayıtlar geriye döndürülmeyecek..
    //Yani şu şekilde 

    public class Product
    {
        public int Id { get; set; }

        public bool IsOnSale { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public short? UnitInStoak { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }



        public override string ToString()
        {
            return $"{ProductName} | {IsOnSale}";
        }
    }
}
