using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRepo.DAL.ORM.Entity
{
    //Bu class ortak özellikleri olan class'lara miras vererek ve ortak olarak sütunların oluşturulmasına yardımcı olacaktır.
    //Aynı zamanda Generic Repository Desing Patern'e uygun kod yazarkende kolaylık sağlayacaktır.
    public class BaseEntity
    {
        [Key]
        [Column(Order = 1)] //Column ile database' de sütun sırasını belirleyebilirsiniz.
        public int Id { get; set; }

        [Column(Order = 2)]
        public string Name { get; set; }
        
        [Column(TypeName ="datetime2")] //Column aynı zamanda sütun tipini de belirleyebilir.
        public DateTime Added_Date { get; set; }

        public bool isActivate { get; set; }
    }
}
