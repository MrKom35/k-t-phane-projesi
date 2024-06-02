using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class formAnasayfa : Form
    {
        public formAnasayfa()
        {
            InitializeComponent();
        }

        //Kİtap İŞlemleri
        private void button1_Click(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.ShowDialog();


        }

        //Öğrenci İşlemleri BUtonu
        private void button2_Click(object sender, EventArgs e)
        {
            //Yeni bir öğrenci formu oluşturuldu
            formOgrenci ogrenci = new formOgrenci();
            //Bu öğrenci formunu gösterelim
            ogrenci.ShowDialog();

        }

      //Kitap Türü İŞlemleri
        private void button3_Click(object sender, EventArgs e)
        {
            formKitapTur kitapturu = new formKitapTur();
            kitapturu.ShowDialog();
        }

        //Ödünç Kitap İşlemleri
        private void button4_Click(object sender, EventArgs e)
        {
            FormOduncKitap odunckitap = new FormOduncKitap();
            odunckitap.ShowDialog();

        }

     
    }
}
