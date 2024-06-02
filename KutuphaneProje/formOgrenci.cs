using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class formOgrenci : Form
    {
        VeriTabaniislemleri vtislem=new VeriTabaniislemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string sorgu;
        public formOgrenci()
        {
            InitializeComponent();
        }
        private void formOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            baglanti = vtislem.baglan();
            baglanti.Open();
            string sorgu = "select * from kutuphanem.ogrenciler";
            MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridOgrenci.DataSource = dt;
            gridOgrenci.Columns["ogrenci_no"].HeaderText = "Oğrenci Nosu";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = vtislem.baglan();
            baglanti.Open();
            string sorgu = "insert into ogrenciler(ogrenci_no,ad,soyad,sinif,cinsiyet,telefon) values(@no,@ad,@soyad,@sinif,@cins,@tel)";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
            komut.Parameters.AddWithValue("@sinif", comboSinif.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@cins", comboCinsiyet.SelectedItem.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

        }

        
        private void gridOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {


           

        }

        //SİL BUTONU 
        private void button2_Click(object sender, EventArgs e)
        {

          

        }

        //GÜNCELLE BUTONU
        private void button3_Click(object sender, EventArgs e)
        {
                  
           


        }

        
        //ARAMA YAPMA
        private void txtAramaOgrenci_TextChanged(object sender, EventArgs e)
        {
            

        }

        public void OgrenciArama(string aranacakKelime) {

        }

       
    }
}
