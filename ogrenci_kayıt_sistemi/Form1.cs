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
using System.IO;


// hastalık tarafını bir grubun içinde iki tane rb olmadıgı için diger gruba tasıdık

namespace ogrenci_kayıt_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=ALI;Initial Catalog=test;Integrated Security=True");

        string resimpath;

        string cinsiyet = "girilmedi";

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_ikametilçe.Visible = false;
            txt_hastalık.Visible = false;
            timer1.Start();
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into ogrenci_kayıt_sistemi(N)", baglan);

            FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] resim = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();
            


            // TCNO İCİN VEYA TEL İCİN VERİTABANIDA burasıda float yapılmalı
            
            cmd.Parameters.AddWithValue("@tcno", Convert.ToInt32(txt_tcno.Text));
            cmd.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd.Parameters.AddWithValue("@tel", txt_tel.Text);
            cmd.Parameters.AddWithValue("@yas", txt_yas.Text);
            cmd.Parameters.AddWithValue("@mail", txt_mail.Text);
            cmd.Parameters.AddWithValue("@Babaadı", txt_babaadı.Text);
            cmd.Parameters.AddWithValue("@Anaadı", txt_anaadı.Text);
            cmd.Parameters.AddWithValue("@Sehir", txt_sehır.Text);
            cmd.Parameters.AddWithValue("@Mahalle", txt_mahalle.Text);
            cmd.Parameters.AddWithValue("@Cadde", txt_cadde.Text);
            cmd.Parameters.AddWithValue("@hastalık", txt_hastalık.Text);
            cmd.Parameters.AddWithValue("@kan", txt_kan.Text);
            // tarih kaydetmek için veritabanında tur bolumune time seciliyor.
            cmd.Parameters.AddWithValue("@tarih", label9.Text);
            cmd.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);


            
            

            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show(" kayıt Başarili ");
                       


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second; ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 veritabanıgostermeekranı = new Form2();
            veritabanıgostermeekranı.Show();
            //this.Hide();

        }

        private void rd_hastalık_var_CheckedChanged(object sender, EventArgs e)
        {
            txt_hastalık.Visible = true;
        }

        private void rd_hastalık_yok_CheckedChanged(object sender, EventArgs e)
        {
            txt_hastalık.Text = "yok";
            txt_hastalık.Visible = false;

        }

        private void btn_gözat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                pb_ogrenci_resim.Image = Image.FromFile(openFileDialog1.FileName);

                resimpath = openFileDialog1.FileName.ToString();

            }
        }

        private void rb_erkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void rb_kız_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kız";
        }

        
        private void btn_ara_Click_1(object sender, EventArgs e)
        {
            Form3 aramaekranı = new Form3();
            aramaekranı.Show();
        }

        private void btn_puan_Click(object sender, EventArgs e)
        {
            Form4 notekranı = new Form4();
            notekranı.Show();
            
        }

        private void tb_ikamet_TextChanged(object sender, EventArgs e)
        {
            // veritabanına atılacak.

            tb_ikametilçe.Visible = true;
        }
    }
}
