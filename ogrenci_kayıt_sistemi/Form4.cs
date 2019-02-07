using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_kayıt_sistemi
{
    public partial class Form4 : Form
    {
        public Form4()  // not girme ve arama
        {
            InitializeComponent();
        }

        int tcno;
        double sonuc=0;

        SqlConnection notgirmebaglantisi = new SqlConnection("Data Source=ALI;Initial Catalog=test;Integrated Security=True");

        private void btn_notgir_Click(object sender, EventArgs e)
        {
            int vizenotu = Int32.Parse(tb_vize.Text);
            int finalnotu = Int32.Parse(tb_final.Text);
            tcno = Int32.Parse(tb_tcno.Text);

            sonuc = vizenotu * 0.4 + finalnotu * 0.6;
            // assagıda sonuc string girilemedi.nedenini bilimiyorum
            // cmd.parameters li kodu girmezsek yenilemiyor. sonucu 
            // update cumlesi de asagıdaki gibidir.

            

            notgirmebaglantisi.Open();

            SqlCommand cmd = new SqlCommand("Update ogrenci_kayıt_sistemi Set vize=" + vizenotu + ",final=" + finalnotu + ",sonuc=" + sonuc + " Where tcno=" + tcno + "", notgirmebaglantisi);

            cmd.Parameters.AddWithValue("@vize", tb_vize.Text);           
            cmd.Parameters.AddWithValue("@final", tb_final.Text);
            cmd.Parameters.AddWithValue("@sonuc", sonuc);



            cmd.ExecuteNonQuery();
            notgirmebaglantisi.Close();
            MessageBox.Show(" not girme Başarili ");

            
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            tcno = Int32.Parse(tb_tcno.Text);



            // assagıdaki kodda select cumlesinde tablonun belirli bolumleri almayı yaptık.

            notgirmebaglantisi.Open();
            SqlDataAdapter data_adp = new SqlDataAdapter("SELECT s.vize,s.final,s.sonuc FROM ogrenci_kayıt_sistemi s  Where tcno=" + tcno + "", notgirmebaglantisi);
            DataSet ds = new DataSet();
            data_adp.Fill(ds, "ogrenci_kayıt_sistemi");
            DataTable tablo1 = new DataTable();
            data_adp.Fill(tablo1);
            dgv_notgir.DataSource = tablo1;
            notgirmebaglantisi.Close();
        }
    }
}
