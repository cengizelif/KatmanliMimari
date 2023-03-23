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
    public class Kategoriler
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp=new SqlDataAdapter("KategoriListesi",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable(); 
            adp.Fill(dt);
            return dt;
        }

        public static bool Ekle(Kategori ktg)
        {
            SqlCommand komut = new SqlCommand("KategoriEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@katAd",ktg.KategoriAdi);
            komut.Parameters.AddWithValue("@tanim", ktg.Tanimi);    

            return Tools.ExecuteNonQuery(komut);

        }
    }
}
