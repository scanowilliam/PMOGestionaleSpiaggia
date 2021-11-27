
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//libreria per utilizzare query sql
using System.Configuration;
using static PMOgestionale.Pattern;

namespace PMOgestionale
{

    public partial class FormGestionale : Form
    {
        //connessione al database con stringa
        string path = @"Data Source=ALIENWARE-M15X\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True";//server e nome database

        int ID;//variabile per poter selezionare la riga da eliminare
        int lettino;
        int ombrellone;
        Subject ListaDattesa = new Subject();//lista per Observer

        Cliente cliente;
        SqlConnection con;//oggetto per la chiamata alla connessione
        SqlCommand cmd;//comando per far girare le query sql
        SqlDataAdapter adpt;

        public FormGestionale()//costruttore
        {
            InitializeComponent();
            txtNome.ShortcutsEnabled = false;//rende impossibile incollare un testo in txtNome
            con = new SqlConnection(path);//iniziallizzo con e gli passo il percorso
            Visualizza();//visualizzo subito i valori della tabella
            btnElimina.Enabled = false;
            dtpInizio.MinDate = DateTime.Now;


            //richiama la funzione che popola la tabella giorno
            //PopolaGiorno.Popola_Giorni(con,cmd);


            //lettura numero lettini, ombrelloni
            lettino = LetturaLO.Lettura_Lettini(con, cmd);
            ombrellone = LetturaLO.Lettura_Ombrelloni(con, cmd);

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "" || txtCognome.Text == "" || cmbOfferta.Text == "" || txtTelefono.Text == "")//la data è predefinita
            {
                MessageBox.Show("Riempi tutti i campi");
            }
            else
            {

                try
                {
                    DateTime inizio = Convert.ToDateTime(dtpInizio.Value).Date;
                    DateTime fine = Convert.ToDateTime(dtpFine.Value).Date;

                    //imposto offerta generica
                    Offerta factory = null;

                    cliente = new Cliente(ID, txtNome.Text, txtCognome.Text, inizio, fine, cmbOfferta.SelectedIndex, txtTelefono.Text);

                    if (cliente.Offerta == 0)//1 lettino
                    {
                        factory = new OfferBase(inizio, fine);
                        cliente.Prezzo = factory.SetPrezzo(cliente);
                        string cac = CalcolaDisponibilta.Calcola_Disponibilta(cliente, 1, 0, lettino, ombrellone, con, cmd);

                        if (cac == "date libere")
                        {
                            InserisciCliente.Inserisci_Cliente(cliente, con, cmd);
                        }
                        else
                        {
                            MessageBox.Show("Data non disponibile");
                            ClienteInAttesa observerB = new ClienteInAttesa(cliente);
                            ListaDattesa.registerObserver(observerB);
                        }

                    }
                    if (cliente.Offerta == 1)//2 lettini + ombrellone
                    {
                        factory = new OfferPlus(inizio, fine);
                        cliente.Prezzo = factory.SetPrezzo(cliente); string cac = CalcolaDisponibilta.Calcola_Disponibilta(cliente, 2, 1, lettino, ombrellone, con, cmd);

                        if (cac == "date libere")
                        {
                            InserisciCliente.Inserisci_Cliente(cliente, con, cmd);
                        }
                        else
                        {
                            MessageBox.Show("Data non disponibile");
                            ClienteInAttesa observerB = new ClienteInAttesa(cliente);
                            ListaDattesa.registerObserver(observerB);
                        }

                    }
                    if (cliente.Offerta == 2)//3 lettini + ombrellone
                    {
                        factory = new OfferExtra(inizio, fine);
                        cliente.Prezzo = factory.SetPrezzo(cliente);
                        string cac = CalcolaDisponibilta.Calcola_Disponibilta(cliente, 3, 1, lettino, ombrellone, con, cmd);
                        if (cac == "date libere")
                        {
                            InserisciCliente.Inserisci_Cliente(cliente, con, cmd);
                        }
                        else
                        {
                            MessageBox.Show("Data non disponibile");
                            ClienteInAttesa observerB = new ClienteInAttesa(cliente);
                            ListaDattesa.registerObserver(observerB);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Visualizza();
        }

        public void Visualizza()//visualizza la tabella cliente
        {
            try
            {
                dtDataGridView.DataSource = VisualizzaClienti.Visualizza_Clienti(con, adpt);//assegno alla gridview l'output della query
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void PulisciCampi()
        {
            txtNome.Text = "";
            txtCognome.Text = "";
            cmbOfferta.Text = "";
            txtTelefono.Text = "";
        }

        //metodo che associa alla griedview i valori in input
        private void dtDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  ID = int.Parse(dtDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
              txtNome.Text = dtDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
              txtCognome.Text = dtDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
              dtpInizio.Text = dtDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
              dtpFine.Text = dtDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
              cmbOfferta.Text = dtDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
              txtTelefono.Text = dtDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();*/

            cliente = new Cliente();
            cliente.ID = int.Parse(dtDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            cliente.Nome = dtDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cliente.Cognome = dtDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            cliente.Data_inizio = Convert.ToDateTime(dtDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            cliente.Data_fine = Convert.ToDateTime(dtDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            cliente.Offerta = Convert.ToInt32(dtDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            cliente.Telefono = dtDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

            btnElimina.Enabled = true;
        }

        private void btnElimina_Click(object sender, EventArgs e)//elmina una prenotazione e resetta i posti liberi
        {
            try
            {

                DateTime ObsInizio = EliminaRecord.Seleziona_Data_Inizio(con, cmd, cliente);
                DateTime ObsFine = EliminaRecord.Seleziona_Data_Fine(con, cmd, cliente);

                int offerta = EliminaRecord.Seleziona_Offerta(con, cmd, cliente);

                EliminaRecord.LiberaLO(offerta, cliente, con, cmd);
                EliminaRecord.Elimina(con, cmd, cliente);

                PulisciCampi();
                Visualizza();

                //notifico chi è il primo in lista in attesa per la data liberata
                foreach (ClienteInAttesa x in ListaDattesa.Observers)
                {
                    if (x.Data_inizio == ObsInizio && x.Data_fine == ObsFine)
                    {
                        ListaDattesa.notifyObservers(x);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRicercaID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtDataGridView.DataSource = Ricerca.Ricerca_Cliente(con, adpt, txtRicercaID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)//fare ereditare il metodo agli altri textbox?
        {
            txtNome.MaxLength = 30;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtCognome_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCognome.MaxLength = 30;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTelefono.MaxLength = 10;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRicercaID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpInizio_ValueChanged(object sender, EventArgs e)
        {
            dtpInizio.MinDate = DateTime.Now;
            dtpFine.MinDate = dtpInizio.Value;
            //dtpInizio.MaxDate=
        }

        private void dtDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbOperazioni_Enter(object sender, EventArgs e)
        {

        }
    }
}
