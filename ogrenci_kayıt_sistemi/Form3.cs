using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_kayıt_sistemi
{
    public partial class Form3 : Form
    {
        public Form3()  // arama ve silme ekranı
        {
            InitializeComponent();
        }
        SqlConnection silmebaglantisi = new SqlConnection("Data Source=ALI;Initial Catalog=test;Integrated Security=True");

        SqlConnection aramabaglantisi = new SqlConnection("Data Source=ALI;Initial Catalog=test;Integrated Security=True");
        int tcno;


        private void btn_ara_Click(object sender, EventArgs e)
        {

            // assagıda ki kodda textboxdan aldıgımız degeri int cevirdikten sonra
            // veritabanına assagıdaki cumlecigi aynen kullanıyoruz .
            // normalde where tcno=5 filan olabilirken biz dısarıdan aldıgımız degerle "++" gibi bir 
            // kullanımla bunu yapıyoruz.


            tcno = Int32.Parse(tb_ara.Text);
            
            
            aramabaglantisi.Open();
            SqlDataAdapter data_adp = new SqlDataAdapter("Select * From ogrenci_kayıt_sistemi Where tcno="+tcno+"", aramabaglantisi);
            DataSet ds = new DataSet();
            data_adp.Fill(ds, "ogrenci_kayıt_sistemi");
            DataTable tablo1 = new DataTable();
            data_adp.Fill(tablo1);
            dgv_ara.DataSource = tablo1;
            aramabaglantisi.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            silmebaglantisi.Open();

            // assagıda delete cumlecıgını kullandık.arasına select deki gibi yıldız kullanılmıyor.

            SqlCommand cmd = new SqlCommand("Delete From ogrenci_kayıt_sistemi Where tcno=" + tcno + "", silmebaglantisi);
            cmd.ExecuteNonQuery();
            silmebaglantisi.Close();
            MessageBox.Show(" silme Başarili ");
        }
    }
}
