using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselRehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            mskTel.Clear();
        }

        KisilerRehberEntities db = new KisilerRehberEntities();
       
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            lst_Kisiler.Items.Clear();
            //Kisiler kisi = new Kisiler();

            //kisi.Ad = txtAd.Text;
            //kisi.Soyad = txtSoyad.Text;
            //kisi.Telefon = mskTel.Text;
            //db.Kisilers.Add(kisi);

            db.Kisilers.Add(new Kisiler { Ad = txtAd.Text, Soyad = txtSoyad.Text, Telefon = mskTel.Text });
            bool kayit =  db.SaveChanges() > 0;
            MessageBox.Show(kayit ? "Kisi basarıyla kaydedildi." : "Kisi ekleme başarısız..");
            KisiListele();
            Temizle();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisiListele();
        }

        private void KisiListele()
        {
            foreach (var kisi in db.Kisilers.ToList())
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = kisi.Id.ToString();
                listItem.SubItems.Add(kisi.Ad);
                listItem.SubItems.Add(kisi.Soyad);
                listItem.SubItems.Add(kisi.Telefon);
                listItem.Tag = kisi;

                lst_Kisiler.Items.Add(listItem);
            }           
        }

        private void lst_Kisiler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lst_Kisiler.SelectedItems[0].Index;

                
        }


        private void KisiListele(string param)
        {
            foreach (var kisi in db.Kisilers.Where(x=> x.Ad.StartsWith(param) || x.Soyad.StartsWith(param) 
            || x.Ad.EndsWith(param) ||x.Soyad.EndsWith(param)).ToList())
            {

            }
        }
    }
}
