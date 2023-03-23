using NorthwindDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL
{
    public class Urunler
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("UrunListesi", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable(); 
            adp.Fill(dt);   
            return dt;
        }

        public static bool Ekle(Urun urn)
        {
            SqlCommand komut = new SqlCommand("UrunEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@urunAdi",urn.UrunAdi);
            komut.Parameters.AddWithValue("@fiyat", urn.BirimFiyati);
            komut.Parameters.AddWithValue("@stok", urn.HedefStokDuzeyi);

            return Tools.ExecuteNonQuery(komut);
      
        }
    }
}
