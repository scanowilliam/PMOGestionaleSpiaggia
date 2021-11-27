using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMOgestionale
{
    public static class PopolaGiorno
    {
        public static void Popola_Giorni(SqlConnection con, SqlCommand cmd)//funzione per popolare la tabella Giorno
        {
            con.Open();
            string dateInput = "Jan 1, 2021";//variabile per riempire di anno in anno
            var parsedDate = DateTime.Parse(dateInput);
            for (int i = 0; i < 365; i++)
            {
                cmd = new SqlCommand("insert into Giorno (Data,Lettino,Ombrellone) values ('" + parsedDate + "','" + 10 + "','" + 5 + "')", con);
                cmd.ExecuteNonQuery();
                parsedDate = parsedDate.AddDays(1);
            }
            con.Close();
        }
    }
}
