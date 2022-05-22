using EfMapping.Orm.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfMapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProjeContext db = new ProjeContext();
            foreach (var item in db.Categories.ToList())
            {
                listBox1.Items.Add(item.CategoryName);
            }

        }
    }
}
