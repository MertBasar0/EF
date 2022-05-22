using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkSorgularTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities _db = new NorthwindEntities();
        private void btn_Sorgu1_Click(object sender, EventArgs e)
        {
            //Unitprice 20-50 arasında olan productid, productname,categoryName

            NorthwindEntities northwindEntities = new NorthwindEntities();

            //linq to entity

           var results = _db.Products.Where(x => x.UnitPrice > 20 && x.UnitPrice < 50)
                .OrderBy(x => x.UnitPrice)
                .Select(x => new
                {
                    x.ProductID,
                    x.ProductName,
                    x.Categories.CategoryName
                }).ToList();
            dataGridView1.DataSource = results;
        }

        private void btn_sorgu2_Click(object sender, EventArgs e)
        {
            //Siparişler tablosundan müşteriŞirketAdı, ÇalışanAdıSoyadı,SiparişId,SiparişTarihi,KargoŞirketAdı getiren sorgu.

            var result = _db.Orders.Select(x => new
            {
                SiparisNo = x.OrderID,
                SiparisTarihi = x.OrderDate,
                KargoSirketAdi = x.Shippers.CompanyName,
                MüşteriSirketAdi = x.Customers.CompanyName,
                CalisanAdi = x.Employees.FirstName,
                CalisanSoyadi = x.Employees.LastName
            }).ToList();
            dataGridView1.DataSource= result;
        }

        private void btn_sorgu3_Click(object sender, EventArgs e)
        {
            //CompanyName içerisinde restaurant geçen müşterileri listeleyiniz. //endwith,startwith,contains

            var results = _db.Customers
                .Where(x => x.CompanyName.Contains("restaurant"))
                .Select(x => new
                {
                    x.CompanyName,
                    x.City  
                }).ToList();

            dataGridView1.DataSource = results;
        }

        private void btn_sorgu4_Click(object sender, EventArgs e)
        {
            //Kategorisi Beverages olan ürün adı:kablo, fiyat:5.00, stokadedi:500 olan ürün ekleyiniz.

            var BeveragesId = _db.Categories.FirstOrDefault(x => x.CategoryName == "Beverages").CategoryID;

            //Products product = new Products()
            //{
            //    ProductName = "VGA",
            //    UnitPrice = 5,
            //    UnitsInStock = 500,
            //    CategoryID = BeveragesId
            //};

            //_db.Products.Add(product);
            IEnumerable<Products> results = _db.Products.Where(x => x.ProductName == "VGA");
            _db.Products.RemoveRange(results);
            _db.SaveChanges();
            dataGridView1.DataSource = _db.Products.Where(x => x.Categories.CategoryID == BeveragesId).ToList();
            
        }
    }
}
