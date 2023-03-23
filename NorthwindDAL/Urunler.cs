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
            komut.Parameters.AddWithValue("@katId", urn.KategoriID);
            komut.Parameters.AddWithValue("@tedId", urn.TedarikciID);
            return Tools.ExecuteNonQuery(komut);
      
        }

        public static bool Sil(int id)
        {
            SqlCommand komut = new SqlCommand("UrunSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@urunId",id);
    
            return Tools.ExecuteNonQuery(komut);

        }
    }
}
