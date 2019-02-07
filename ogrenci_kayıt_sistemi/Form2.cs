using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_kayıt_sistemi
{
    public partial class Form2 : Form
    {
        public Form2()  // veri tabanı gösterme ekranı
        {
            InitializeComponent();
        }

        SqlConnection listelebaglantisi = new SqlConnection("Data Source=ALI;Initial Catalog=test;Integrated Security=True");


        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            listelebaglantisi.Open();
            SqlDataAdapter data_adp = new SqlDataAdapter("Select * From ogrenci_kayıt_sistemi", listelebaglantisi);
            DataSet ds = new DataSet();
            data_adp.Fill(ds, "ogrenci_kayıt_sistemi");
            DataTable tablo1 = new DataTable();
            data_adp.Fill(tablo1);
            dgv_listele.DataSource = tablo1;
            listelebaglantisi.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
