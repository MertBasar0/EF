using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfSorgular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();

        private void btn_sorguBir_Click(object sender, EventArgs e)
        {
            #region Sql Sorgusu Soru
            //Unitprice 20 - 50 arasında olan productId, productName, categoryName
            #endregion

            #region LINQ to Entity

            //decimal a = Convert.ToDecimal(this.textBox1.Text);
            //decimal b = Convert.ToDecimal(this.textBox2.Text);

            //dgvSorgular.DataSource = db.Products.Where(x=> x.UnitPrice>a && x.UnitPrice<b).OrderBy(x=>x.UnitPrice).
            //    OrderByDescending(x=>x.UnitPrice).Select(x=>new
            //{
            //    x.ProductID,
            //    x.ProductName,
            //    x.UnitPrice,
            //    x.Categories.CategoryName
            //}).ToList();

            #endregion
            

            #region Linq to Sql

            //var result = from p in db.Products
            //             where p.UnitPrice >= 20 && p.UnitPrice <= 50
            //             orderby p.UnitPrice descending
            //             select new
            //             {
            //                 UrunId = p.ProductID,
            //                 UrunAdi = p.ProductName,
            //                 Fiyat = p.UnitPrice,
            //                 StokAdet = p.UnitsInStock,
            //                 KategoryAdi = p.Categories.CategoryName
            //             };
            //dgvSorgular.DataSource = result.ToList();


            var sonuc =              from x in db.Orders
                                     select new
                                     {
                                         MusteriSirketiAdi = x.Customers.CompanyName,
                                         CalisanAdiSoyadi = x.Employees.FirstName + "" + x.Employees.LastName,
                                         SiparisAdi = x.OrderDate,
                                         KargoŞirketiAdi = x.Shippers.CompanyName
                                     };
            dgvSorgular.DataSource = sonuc.ToList();

            #endregion
        }

        private void btn_sorgu2_Click(object sender, EventArgs e)
        {
            #region Soru
            //Sipariş tablosundan müşteriSirketAdi, calisanAdiSoyadi, SiparisId, siparisTarihi ve kargo şirketiAdi getiren sorguyu yazınız.

            dgvSorgular.DataSource = db.Orders.Select(x => new
            {
                MüşteriAdi = x.Customers.CompanyName,
                CalisanAdi = x.Employees.FirstName,
                CalisanSoyadi = x.Employees.LastName,
                SiparisNo = x.OrderID,
                KargoSirketi = x.Shippers.CompanyName
            }).ToList();

            #endregion
        }

        private void btn_Sorgu4_Click(object sender, EventArgs e)
        {
            int kateforyId = db.Categories.FirstOrDefault(x => x.CategoryName == "Beverages").CategoryID;

            Products urun = new Products();
            urun.CategoryID = kateforyId;
            urun.ProductName = "Kablo";
            urun.UnitPrice = 5;
            urun.UnitsInStock = 500;

            db.Products.Add(urun);
            db.SaveChanges();

            #region 2.Yol

            db.Products.Add(new Products
            {
                ProductName = "VGA",
                UnitPrice = 8,
                UnitsInStock = 800,
                CategoryID = db.Categories.FirstOrDefault(x=>x.CategoryName == "Beverages").CategoryID

            });
            db.SaveChanges();

            #endregion

            #region 3.yol
            db.Categories.FirstOrDefault(x => x.CategoryName == "Beverages").Products.Add(new Products
            {
                ProductName = "HDMI",
                UnitPrice = 60,
                UnitsInStock = 200
            });
            db.SaveChanges();

            dgvSorgular.DataSource = db.Products.Where(x=>x.Categories.CategoryID == kateforyId);
            #endregion
        }

        private void btn_Sorgu5_Click(object sender, EventArgs e)
        {
            //Çalışanların adını, soyadını, doğum tarihlerini ve yaşını getiren bir sorgu yazınız.

            #region linq to entity

            //dgvSorgular.DataSource = db.Employees.Select(x => new
            //{
            //    Adi = x.FirstName,
            //    Soyadi = x.LastName,
            //    DogumTarihi = x.BirthDate,
            //    Yasi = System.Data.Objects.SqlClient.SqlFunctions.DateDiff("year", x.BirthDate, DateTime.Now)

            //}).ToList();

            #endregion



            #region linq to sql

            dgvSorgular.DataSource =  (from x in db.Employees
                                      select new
                                      {
                                          adiSoyadi = x.FirstName + " " + x.LastName,
                                          DogumTarihi = x.BirthDate,
                                          Yasi = System.Data.Objects.SqlClient.SqlFunctions.DateDiff("year",x.BirthDate,DateTime.Now)
                                      }).ToList();

            #endregion
        }

        private void btn_sorgu6_Click(object sender, EventArgs e)
        {
            //Kategorilerine göre stoktaki ürün sayısını veren sorguyu yazınız.
            #region linq to entity
            //dgvSorgular.DataSource = db.Products.GroupBy(x => x.Categories.CategoryName).Select(z => new
            //{
            //    KategoriAdi = z.Key,
            //    UrunAdet = z.Sum(x=> x.UnitsInStock)
            //}).ToList();


            #endregion


            var sonuc = from x in db.Products
                        group x by x.Categories.CategoryName into g
                        select new
                        {
                            KategoriAdi = g.Key,
                            ToplamStokAdet = g.Sum(x=> x.UnitsInStock)
                        };
            dgvSorgular.DataSource = sonuc.ToList();

        }
    }
}
