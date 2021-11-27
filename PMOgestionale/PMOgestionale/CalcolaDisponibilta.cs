using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMOgestionale
{
    public static class CalcolaDisponibilta
    {
        public static string Calcola_Disponibilta(Cliente c,int lettino_c, int ombrellone_c,int lettino, int ombrellone, SqlConnection con, SqlCommand cmd)
        {
            bool tmp = true;
            string result = "";
            DateTime dmp = c.Data_inizio;
            //funzione che controlla se le date sono libere e se vi sono lettini o ombrelloni disponibili
            while (dmp <= c.Data_fine && tmp)
            {
                con.Open();
                cmd = new SqlCommand("select Lettino from Giorno where (Data='" + dmp + "')", con);
                cmd.Parameters.AddWithValue("@Lettino", lettino);
                lettino = Convert.ToInt32(cmd.ExecuteScalar());
                
                cmd = new SqlCommand("select Ombrellone from Giorno where (Data='" + dmp + "')", con);
                cmd.Parameters.AddWithValue("@Ombrellone", ombrellone);
                ombrellone = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                //controlla se una data è occupata, se lo è mette il flag a falso
                if (lettino_c > lettino || ombrellone_c > ombrellone || lettino <= 0 || ombrellone <= 0)
                {
                    tmp = false;
                }
                dmp = dmp.AddDays(1);//incremento il giorno, usando la data stessa come contatore
            }
            //se entra in questo if vado ad aggiornare il numero effettivo
            if (tmp == true)
            {
                dmp = c.Data_inizio;
                lettino -= lettino_c;
                ombrellone -= ombrellone_c;
                while (dmp <= c.Data_fine && tmp)//aggiorno giorno per giorno
                {
                    con.Open();
                    cmd = new SqlCommand("update Giorno set Lettino='" + lettino + "',Ombrellone='" + ombrellone + "'where(Data='" + dmp + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dmp = dmp.AddDays(1);
                }
                result = "date libere";

            }
            else
            {
                result = "Data non disponibile";


            }
            return result;

        }
    }
}
