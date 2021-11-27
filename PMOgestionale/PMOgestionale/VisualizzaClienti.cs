using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMOgestionale
{
    public static class VisualizzaClienti
    {
        public static DataTable Visualizza_Clienti(SqlConnection con,SqlDataAdapter adpt)
        {
            DataTable dt = new DataTable();//inizializzo l'oggetto dt
            con.Open();
            adpt = new SqlDataAdapter("select * from Cliente", con);
            adpt.Fill(dt);
            con.Close();
            return dt;//assegno alla gridview l'output della query
        }

    }
}
