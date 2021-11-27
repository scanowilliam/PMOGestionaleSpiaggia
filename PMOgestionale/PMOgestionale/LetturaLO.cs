using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMOgestionale
{
    public static class LetturaLO
    {
        public static int Lettura_Lettini(SqlConnection con, SqlCommand cmd)
        {
            int lettino=0;
            con.Open();
            cmd = new SqlCommand("select Lettino from Giorno", con);
            cmd.Parameters.AddWithValue("@Lettino", lettino);
            lettino = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return lettino;
        }

        public static int Lettura_Ombrelloni(SqlConnection con, SqlCommand cmd)
        {
            int ombrellone = 0;
            con.Open();
            cmd = new SqlCommand("select Ombrellone from Giorno", con);
            cmd.Parameters.AddWithValue("@Ombrellone", ombrellone);
            ombrellone = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return ombrellone;

        }
    }
}
