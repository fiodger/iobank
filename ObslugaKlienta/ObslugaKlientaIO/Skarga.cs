using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class Skarga : Zgłoszenia
    {
        private int idDzialuSkargi;
        private bool czyPoinformowanoDzial;

        public Skarga()
        {

        }

        public Skarga(int idDzialuSkargi, bool czyPoinformowanoDzial, int IdZglosznia, bool czyOdczytane, bool czyPoinformowanoKlienta)
        {
            this.IdZgloszenia = IdZglosznia;
            this.CzyOdczytane = czyOdczytane;
            this.CzyPoinformowanoKienta = czyPoinformowanoKlienta;
            this.idDzialuSkargi = idDzialuSkargi;
            this.czyPoinformowanoDzial = czyPoinformowanoDzial;
        }

        public void WpiszTresc()
        {
            //Odbiór informacji z komponentu graficznego i przypisanie do pól klasy
            Console.WriteLine("Pobieranie treści zgłoszeni nr " + IdZgloszenia + " z interfejsu.");
        }

        public string[] TrescOdpowiedzi
        {
            get
            {
                return base.TrescOdpowiedzi;
            }

            set
            {
                base.TrescOdpowiedzi = value;
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

        public int IdDzialuSkargi
        {
            get
            {
                return idDzialuSkargi;
            }

            set
            {
                idDzialuSkargi = value;
            }
        }

        public bool CzyPoinformowanoDzial
        {
            get
            {
                return czyPoinformowanoDzial;
            }

            set
            {
                czyPoinformowanoDzial = value;
            }
        }


        public void PoinformujDzial(int idDzialu, int idZgloszenia)
        {
            foreach (Zgłoszenia zgloszenie in MenedzerZgloszen.bazaZgloszen)
            {
                if (zgloszenie.IdZgloszenia == idZgloszenia)
                {
                    Console.WriteLine("Wysyłanie skargi nr " + IdZgloszenia + "do działu nr " + idDzialu);
                }
                else
                {
                    Console.WriteLine("Skarga o nr " + IdZgloszenia + " nie istnieje w bazie.");
                }
            }
        }
        public void PoinformujAdministratora(Administrator administratora)
        {
            //Informowanie administatora o skardze na dany dzial
            Console.WriteLine("Informowanie administratowa o nr "+ administratora.IdAdministratora + " droga mailowa na adres " + administratora.AdresMailowy + " o pojawieniu sie skargi na dzial o nr " + idDzialuSkargi);
        }
    }
}
