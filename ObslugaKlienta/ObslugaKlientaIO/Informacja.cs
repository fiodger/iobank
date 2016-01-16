using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class Informacja : Zgłoszenia
    {
        public Informacja()
        {

        }

        public Informacja(int IdZglosznia, bool czyOdczytane, bool czyPoinformowanoKlienta)
        {
            this.IdZgloszenia = IdZglosznia;
            this.CzyOdczytane = czyOdczytane;
            this.CzyPoinformowanoKienta = czyPoinformowanoKlienta;

        }

        public void WpiszTresc()
        {
            //Odbiór informacji z komponentu graficznego i przypisanie do pól klasy
            Console.WriteLine("Pobieranie treści zgłoszeni nr " + IdZgloszenia);
        }

        public string[] TrescOdpowiedzi
        {
            get
            {
                return base.TrescOdpowiedzi;
            }
        }

        public bool CzyPoinformowanoKienta
        {
            get
            {
                return base.CzyPoinformowanoKienta;
            }

            set
            {
                base.CzyPoinformowanoKienta = value;
            }
        }

        public bool CzyOdczytane
        {
            get
            {
                return base.CzyOdczytane;
            }

            set
            {
                base.CzyOdczytane = value;
            }
        }

        public int IdZgloszenia
        {
            get
            {
                return base.IdZgloszenia;
            }

            set
            {
                base.IdZgloszenia = value;
            }
        }
    }
}
