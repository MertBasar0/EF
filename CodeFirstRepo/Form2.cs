using CodeFirstRepo.DAL.ORM.Context;
using CodeFirstRepo.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstRepo
{
    public partial class Form2 : Form
    {
        Form1 mainform;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            mainform = f1;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Product pr = new Product()
                {
                    Added_Date = DateTime.Now,
                    Name = textBox1.Text,
                    UnitPrice = decimal.Parse(textBox2.Text),
                    UnitInStock = short.Parse(textBox3.Text),
                    QuantityPerUnit = textBox4.Text,
                    isActivate = true,
                };


                using (TestContext db = new TestContext())
                {
                    db.Products.Add(pr);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bilgileri doğru giriniz..");
            }
           

            MessageBox.Show("Ürün ekleme işlemi başarılı.","test",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform = new Form1();
            mainform.Show();
        }
    }
}
