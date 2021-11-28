using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMOgestionale
{
    static class Pattern
    {
        //interfaccia subject
        public interface ISubject
        {
            void registerObserver(ClienteInAttesa observer);
            void unregisterObserver(ClienteInAttesa observer);
            void notifyObservers(ClienteInAttesa observer);

        }
        //concrete subject, implementa i membri e collega/scollega gli observer
        public class ProductSubject : ISubject
        {
            private List<ClienteInAttesa> observers = new List<ClienteInAttesa>();

            internal List<ClienteInAttesa> Observers { get => observers; set => observers = value; }

            public void registerObserver(ClienteInAttesa observer)
            {
                Observers.Add(observer);
                MessageBox.Show(observer.ObserverName, "registrato");
            }
            public void unregisterObserver(ClienteInAttesa observer)
            {
                Observers.Remove(observer);
            }
            public void notifyObservers(ClienteInAttesa observer)//notifica al gestore gli utenti che erano in attesa nella data liberata
            {
                observer.Notifica(observer);
            }
        }
        public interface IObserver
        {
            void Notifica(ClienteInAttesa observer);

        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// clienteinattesa=observer
        public class ClienteInAttesa : IObserver
        {
            private string observerName;
            private string nome;
            private string cognome;
            private DateTime data_inizio;
            private DateTime data_fine;
            private int offerta;
            private double prezzo;
            private string telefono;

            public string ObserverName { get => observerName; set => observerName = value; }
            public string Nome { get => nome; set => nome = value; }
            public string Cognome { get => cognome; set => cognome = value; }
            public DateTime Data_inizio { get => data_inizio; set => data_inizio = value; }
            public DateTime Data_fine { get => data_fine; set => data_fine = value; }
            public int Offerta { get => offerta; set => offerta = value; }
            public double Prezzo { get => prezzo; set => prezzo = value; }
            public string Telefono { get => telefono; set => telefono = value; }

            //costruttore
            public ClienteInAttesa(Cliente c)//mettere cliente come observer
            {
                ObserverName = c.ID.ToString();
                nome = c.Nome;
                cognome = c.Cognome;
                data_inizio = c.Data_inizio;
                data_fine = c.Data_fine;
                offerta = c.Offerta;
                prezzo = c.Prezzo;
                telefono = c.Telefono;
            }
            public void Notifica(ClienteInAttesa observer)
            {
                MessageBox.Show("la prenotazione in data " + observer.Data_inizio.ToShortDateString() + " a " + observer.Data_fine.ToShortDateString() + " è ora disponibile, affrettati!, contatta " + observer.Nome + " " + observer.Cognome + " al " + observer.Telefono + " ");

            }
        }
        /// <summary> pattern factory

        //offerta generale, product
        public abstract class Offerta
        {
            public abstract DateTime DataInizio { get; set; }
            public abstract DateTime DataFine { get; set; }
            public abstract double SetPrezzo(Cliente c);
        }
        //offerta base, concrete product
        public class OfferBase : Offerta
        {
            private DateTime _dataInizio;
            private DateTime _dataFine;

            public OfferBase(DateTime dataInizio, DateTime dataFine)
            {
                _dataInizio = dataInizio;
                _dataFine = dataFine;
            }      

            public override DateTime DataInizio
            {
                get { return _dataInizio; }
                set { _dataInizio = value; }
            }

            public override DateTime DataFine
            {
                get { return _dataFine; }
                set { _dataFine = value; }
            }

            public override double SetPrezzo(Cliente c)
            {
                double prezzo_g = 5;
                double prezzo_finale = prezzo_g * (c.Data_fine - c.Data_inizio).Days;
                if (c.Data_fine == c.Data_inizio)
                { prezzo_finale = prezzo_g; }
                //l'offerta base ha un prezzo che varia a seconda dei giorni di prenotazione, il numero di posti può essere limitato
                return prezzo_finale;
            }
        }
        //offerta plus
        public class OfferPlus : Offerta
        {
            private DateTime _dataInizio;
            private DateTime _dataFine;

            public OfferPlus(DateTime dataInizio, DateTime dataFine)
            {
                _dataInizio = dataInizio;
                _dataFine = dataFine;
            }        

            public override DateTime DataInizio
            {
                get { return _dataInizio; }
                set { _dataInizio = value; }
            }

            public override DateTime DataFine
            {
                get { return _dataFine; }
                set { _dataFine = value; }
            }

            public override double SetPrezzo(Cliente c)
            {
                double prezzo_g = 10;
                double prezzo_finale = prezzo_g * (c.Data_fine - c.Data_inizio).Days;
                if (c.Data_fine == c.Data_inizio)
                { prezzo_finale = prezzo_g; }
                //l'offerta base ha un prezzo che varia a seconda dei giorni di prenotazione, il numero di posti può essere limitato
                return prezzo_finale;
            }
        }
        //offerta extra
        public class OfferExtra : Offerta
        {
            private DateTime _dataInizio;
            private DateTime _dataFine;

            public OfferExtra(DateTime dataInizio, DateTime dataFine)
            {
                _dataInizio = dataInizio;
                _dataFine = dataFine;
            }
          
            public override DateTime DataInizio
            {
                get { return _dataInizio; }
                set { _dataInizio = value; }
            }

            public override DateTime DataFine
            {
                get { return _dataFine; }
                set { _dataFine = value; }
            }

            public override double SetPrezzo(Cliente c)
            {
                double prezzo_g = 15;
                double prezzo_finale = prezzo_g * (c.Data_fine - c.Data_inizio).Days;
                if (c.Data_fine == c.Data_inizio)
                { prezzo_finale = prezzo_g; }
                //l'offerta base ha un prezzo che varia a seconda dei giorni di prenotazione, il numero di posti può essere limitato
                return prezzo_finale;
            }
        }
        //creator
        abstract class OffertaFactory
        {
            public abstract Offerta GetOfferta();
        }

        //concrete creator base
        class OffertaBaseFactory : OffertaFactory
        {
            private DateTime _dataInizio;
            private DateTime _dataFine;

            public OffertaBaseFactory(DateTime dataInizio, DateTime dataFine)
            {
                _dataInizio = dataInizio;
                _dataFine = dataFine;
            }

            public override Offerta GetOfferta()
            {
                return new OfferBase(_dataInizio, _dataFine);
            }
        }
        //concrete creator plus
        class OfferPlusFactory : OffertaFactory
        {
            private DateTime _dataInizio;
            private DateTime _dataFine;

            public OfferPlusFactory(DateTime dataInizio, DateTime dataFine)
            {
                _dataInizio = dataInizio;
                _dataFine = dataFine;
            }

            public override Offerta GetOfferta()
            {
                return new OfferBase(_dataInizio, _dataFine);
            }
        }
        //concrete creator extra
        class OfferExtraFactory : OffertaFactory
        {
            private DateTime _dataInizio;
            private DateTime _dataFine;

            public OfferExtraFactory(DateTime dataInizio, DateTime dataFine)
            {
                _dataInizio = dataInizio;
                _dataFine = dataFine;
            }

            public override Offerta GetOfferta()
            {
                return new OfferBase(_dataInizio, _dataFine);
            }
        }

        [STAThread]
        static void Main()
        {         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGestionale());
        }
    }
}
