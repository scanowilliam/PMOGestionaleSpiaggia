using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMOgestionale
{
    public static class Ricerca
    {
        public static DataTable Ricerca_Cliente(SqlConnection con, SqlDataAdapter adpt, string testoRicerca)//ricerca tramite id
        {
            DataTable dt = new DataTable();//inizializzo l'oggetto dt
            con.Open();
            adpt = new SqlDataAdapter("select * from Cliente where Id_Cliente like '%" + testoRicerca + "%' ", con);
            adpt.Fill(dt);
            con.Close();
            return dt;//assegno alla gridview l'output della query
        }
    }
}
