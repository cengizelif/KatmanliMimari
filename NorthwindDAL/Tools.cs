using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL
{
    public class Tools
    {
        private static SqlConnection _baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti1"].ConnectionString);

        public static SqlConnection Baglanti
        {
            get { return _baglanti; }
        }

        public static bool ExecuteNonQuery(SqlCommand komut)
        {
            try
            {
                if (komut.Connection.State != System.Data.ConnectionState.Open)
                {
                    komut.Connection.Open();
                    int sonuc = komut.ExecuteNonQuery();
                    return sonuc > 0 ? true : false;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (komut.Connection.State == System.Data.ConnectionState.Open)
                {
                    komut.Connection.Close();
                }

            }


        }
    }
}
