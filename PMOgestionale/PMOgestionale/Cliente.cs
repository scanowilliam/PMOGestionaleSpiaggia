using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMOgestionale
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string cognome;
        private DateTime data_inizio;
        private DateTime data_fine;
        private int offerta;
        private double prezzo;
        private string telefono;
        
        

        //costruttore
        public Cliente(int id,string nome, string cognome, DateTime data_inizio, DateTime data_fine, int offerta, string telefono)//mettere cliente come observer
        {
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.data_inizio = data_inizio;
            this.data_fine = data_fine;
            this.offerta = offerta;
            this.prezzo = 0;
            this.telefono = telefono;
            
        }


        public Cliente()//mettere cliente come observer
        {
            this.id = -1;
            this.nome = "";
            this.cognome = "";
            this.data_inizio = DateTime.Now;
            this.data_fine = DateTime.Now;
            this.offerta = -1;
            this.prezzo = 0;
            this.telefono = "";

        }


        //metodi getter e setter
        public int ID { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public DateTime Data_inizio { get => data_inizio; set => data_inizio = value; }
        public DateTime Data_fine { get => data_fine; set => data_fine = value; }
        public int Offerta { get => offerta; set => offerta = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        public string Telefono { get => telefono; set => telefono = value; }

    }

}
