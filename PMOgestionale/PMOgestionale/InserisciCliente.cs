using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PMOgestionale
{
    public static class InserisciCliente
    {

        public static void Inserisci_Cliente(Cliente c, SqlConnection con, SqlCommand cmd)
        {
            con.Open();
            cmd = new SqlCommand("insert into Cliente (Nome_Cliente,Cognome_Cliente,Data_Inizio,Data_Fine,Offerta,Prezzo,Telefono) values ('" + c.Nome + "','" + c.Cognome + "','" + c.Data_inizio + "','" + c.Data_fine + "' ,'" + c.Offerta + "','" + c.Prezzo + "','" + c.Telefono + "')", con);//aggiungere il prezzo
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Cliente inserito con successo");
            
        }

        
    }
}
