using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PMOgestionale.Pattern;
using System.Windows.Forms;

namespace PMOgestionale
{
    public static class EliminaRecord
    {
        //seleziono la data di inizio e fine di una prenotazione da eliminare
        public static DateTime Seleziona_Data_Inizio(SqlConnection con, SqlCommand cmd, Cliente c)
        {
            
                con.Open();
           
                cmd = new SqlCommand("select Data_Inizio from Cliente where Id_Cliente='" + c.ID + "' ", con);

                cmd.Parameters.AddWithValue("@Data_Inizio", c.Data_inizio);
                c.Data_inizio = Convert.ToDateTime(cmd.ExecuteScalar());
                con.Close();
                return c.Data_inizio;
           
        }

        public static DateTime Seleziona_Data_Fine(SqlConnection con, SqlCommand cmd, Cliente c)
        {
            con.Open();
            cmd = new SqlCommand("select Data_Fine from Cliente where Id_Cliente='" + c.ID + "' ", con);
            cmd.Parameters.AddWithValue("@Data_Fine", c.Data_fine);
            c.Data_fine = Convert.ToDateTime(cmd.ExecuteScalar());
            con.Close();
            return c.Data_fine;
        }

        public static int Seleziona_Offerta(SqlConnection con, SqlCommand cmd, Cliente c)//prendo l'offerta che poi userò per riaggiungere i lettini/ombrelloni liberati
        {
            con.Open();
            cmd = new SqlCommand("select Offerta from Cliente where Id_Cliente='" + c.ID + "' ", con);
            cmd.Parameters.AddWithValue("@Offerta", c.Offerta);
            c.Offerta = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteNonQuery();
            con.Close();
            return c.Offerta;
        }

        public static void LiberaLO(int offerta, Cliente c, SqlConnection con, SqlCommand cmd)//aggiunge lettini/ombrelloni liberati
        {
            switch (offerta)
            {
                case 0:
                    while (c.Data_inizio <= c.Data_fine)
                    {
                        con.Open();
                        cmd = new SqlCommand("update Giorno set Lettino=Lettino+1 where(Data='" + c.Data_inizio + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        c.Data_inizio = c.Data_inizio.AddDays(1);
                    }
                    break;

                case 1:
                    while (c.Data_inizio <= c.Data_fine)
                    {
                        con.Open();
                        cmd = new SqlCommand("update Giorno set Lettino=Lettino+2, Ombrellone=Ombrellone+1 where(Data='" + c.Data_inizio + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        c.Data_inizio = c.Data_inizio.AddDays(1);
                    }
                    break;

                case 2:
                    while (c.Data_inizio <= c.Data_fine)
                    {
                        con.Open();
                        cmd = new SqlCommand("update Giorno set Lettino=Lettino+3, Ombrellone=Ombrellone+1 where(Data='" + c.Data_inizio + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        c.Data_inizio = c.Data_inizio.AddDays(1);
                    }
                    break;

            }
        }

        public static void Elimina(SqlConnection con, SqlCommand cmd, Cliente c)
        {
            //eliminazione effettiva della riga
            con.Open();
            cmd = new SqlCommand("delete from Cliente where Id_Cliente='" + c.ID + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Prenotazione eliminata");
        }
    }
}
