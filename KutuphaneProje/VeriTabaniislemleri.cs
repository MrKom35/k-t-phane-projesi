using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Configuration.Assemblies;



namespace KutuphaneProje
{
    internal class VeriTabaniislemleri
    {

        string baglanticumlesi = "server=localhost;database=kutuphanem;userid=root;pwd=00000000";

        public  MySqlConnection baglan() {
            MySqlConnection baglanti = new MySqlConnection(baglanticumlesi);
            MySqlConnection.ClearPool(baglanti);//Önceki bağlantilar temizlendi
            return baglanti;
        }

    }
}
