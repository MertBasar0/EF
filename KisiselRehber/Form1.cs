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
            lst_Kisiler.Items.Clear();
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
        Kisiler guncellenecek;

        private void lst_Kisiler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lst_Kisiler.SelectedItems[0].Index;
            guncellenecek = lst_Kisiler.SelectedItems[0].Tag as Kisiler;

            txtAd.Text = guncellenecek.Ad;
            txtSoyad.Text = guncellenecek.Soyad;
            mskTel.Text = guncellenecek.Telefon;
                
        }


        private void KisiListele(string param)
        {
            lst_Kisiler.Items.Clear();
            foreach (var kisi in db.Kisilers.Where(x=> x.Ad.StartsWith(param) || x.Soyad.StartsWith(param) 
            || x.Ad.EndsWith(param) ||x.Soyad.EndsWith(param)).ToList())
            {
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = kisi.Id.ToString();
                lvi.SubItems.Add(kisi.Ad);
                lvi.SubItems.Add(kisi.Soyad);
                lvi.SubItems.Add(kisi.Telefon);
                lvi.Tag = kisi;

                lst_Kisiler.Items.Add(lvi);
            }
        }

        private void txtKisiAra_TextChanged(object sender, EventArgs e)
        {
            KisiListele(txtKisiAra.Text);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            guncellenecek.Ad = txtAd.Text;
            guncellenecek.Soyad = txtSoyad.Text;
            guncellenecek.Telefon = mskTel.Text;

            db.SaveChanges();
            KisiListele();
            Temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (lst_Kisiler.SelectedItems.Count <= 0) return; // Bir şey seçili değilse,
            {
                int id = ((Kisiler)lst_Kisiler.SelectedItems[0].Tag).Id;
                Kisiler silinecekKisi = db.Kisilers.Find(id);
                db.Kisilers.Remove(silinecekKisi);
                db.SaveChanges();
                KisiListele();
            }
        }
    }
}
