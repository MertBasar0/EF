using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevProjeesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kisi> kisiler = new List<Kisi>();

        List<Kisi> Aramalar;
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kisi ks = new Kisi();

                ks.Ad = txt_Ad.Text;
                ks.Soyad = txt_Soyad.Text;
                ks.Email = txt_Mail.Text;
                ks.TCKN = txt_Tckn.Text;

                kisiler.Add(ks);
                FormuTemizle();
                lst_liste.Items.AddRange(kisiler.ToArray());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);    
            }
            
        }

        public void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name == "txt_Ad")
                    {
                        continue;
                        item.Text = "";
                    }
                }
                else if (item is ListBox lr)
                {
                    lr.Items.Clear();
                }
            }
        }

        private void txt_KisiAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txt_KisiAra.Text.ToLower();

            Aramalar = new List<Kisi>();

            foreach (Kisi item in kisiler)
            {
                if (item.Ad.ToLower().Contains(ara) || item.Soyad.ToLower().Contains(ara) || item.TCKN.Contains(ara))
                {
                    Aramalar.Add(item);
                }
            }
            FormuTemizle();
            lst_liste.Items.AddRange(Aramalar.ToArray());

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            //Entity Fre. dahil edilecek..
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

        }
    }
}
