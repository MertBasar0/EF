using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Entity Framework => database in taşınmasına projeye entegre eden bir freamworkdür. EF 'ün 3 yapısı vardır. Bunlar;
        //DatabaseFirst yaklaşımı (şuan kullandığımız) => hazır bir db var ise ve bunu kullanacak iseniz o dbnin yansımasını
        //uygulamaya yansıtır. (yeni veritabanındaki tabloları projenize class olarak genereate eder. Kod tarafından bu
        // yansıma üzerinde çalışır. Çok büyük yapılarda db'lerde yavaşlamalar olabilir.)

        //2- Model First yaklaşımı => Proje tarafında database oluşturulur.Tablolar projede oluşturulur. Daha sonra bunun şeması
        //db tarafından çıkarılır.

        //3-Code First yaklaşımı => Herhangi bir yansıma yoktur tamamen yansımayı kendiniz  yazarsınız. Örneğin employees tablom
        //olacak bunun için gidip classımı kendim yazarım. Prıgram çalıştırıldığında database arkada kendisi yaratılır.


        //Entity Framework bir orm mimarisidir.
        //Orm(object relation mapping) => Veritabanımızda oluşturmuş olduğumuz her bir nesneye karşılık kod tarafında
        //bir nesne oluşturan programlardır.

        //Bu programlar code generation tekniği kullanılarak bizim yazmamız gereken kodları otomatik olarak üretir. OOP mantığına uygun
        //şekilde bizim veritabanımızda bulunan tabloları birer nesne örnelerini oluşturur.

        //Not : yansıma dediğim bu nesneler cache'atılır.


        private void btn_musteriGetir_Click(object sender, EventArgs e)
        {
            #region Eski Yöntemler

            //SqlConnection connection = new SqlConnection("Server = LAPTOP-AK0MLSE8 ;Database=Northwind; UID=LAPTOP-AK0MLSE8\\Lenovo; Integrated Security = true");
            //SqlCommand cmd = new SqlCommand();
            //if (connection.State == ConnectionState.Closed)
            //{
            //    connection.Open();
            //    cmd.Connection = connection;
            //    cmd.CommandText = "select * from Employees";
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        DataTable dataTable = new DataTable();
            //        dataTable.Load(dr);
            //        connection.Close();

            //        dgv_sonuclar.DataSource = dataTable;

            //    }
            //    else
            //    {
            //        MessageBox.Show("Okuma işlemi yapılamadı..");
            //    }
            //}
            #endregion
            NorthwindEntities db = new NorthwindEntities();

            dgv_sonuclar.DataSource = db.Customers.ToList();
            dgv_sonuclar.DataSource = db.Products.ToList();


        }
    }
}
