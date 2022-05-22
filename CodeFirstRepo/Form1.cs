using CodeFirstRepo.DAL.ORM.Context;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_psw.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TestContext db = new TestContext();
                if (db.Users.Any(x => x.UserName == txt_kadi.Text && x.Password == txt_psw.Text))
                {
                    Form2 form = new Form2(this);
                    this.Hide();
                    form.Show();


                    label3.Text = "giriş başarılı..";
                }
                else
                {
                    label3.Text = "giriş hatalı..";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi doğru giriniz.."+ ex.Message);
                
            }
            
        }
    }
}
