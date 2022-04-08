using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkGirisTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AccountDbEntities ds = new AccountDbEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_results.DataSource = ds.Hesap.ToList();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {

            dgv_results.DataSource = ds.Hesap.ToList();

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            Hesap hp = new Hesap { ad = txt_name.Text, soyad = txt_surname.Text, tc = txt_tckn.Text, bakiye = Convert.ToDecimal(txt_total.Text) };
            if (Karsilastir(hp))
            {
                MessageBox.Show("kişi mevcut");
            }
            else
            {
                ds.Hesap.Add(hp);
                ds.SaveChanges();
            } 
            dgv_results.DataSource=ds.Hesap.ToList();
        }


        public bool Karsilastir(Hesap hesap)
        {
            bool result = false;
            foreach (var item in ds.Hesap)
            {
                if (item.ad == hesap.ad && item.soyad == hesap.soyad && item.bakiye == hesap.bakiye)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_deleteId.Text);
            if (ds.Hesap.Find(id) != null)
            {
                ds.Hesap.Remove(ds.Hesap.Find(id));
                ds.SaveChanges();
                dgv_results.DataSource = ds.Hesap.ToList();
            }
            else
            {
                MessageBox.Show("kişi bulunamadı");
            }
        }
    }
}
