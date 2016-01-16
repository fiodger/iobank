using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class Reklamacja : Zgłoszenia
    {
        private int idReklamowanegoDziału;
        private int liczbaDniNaRealizacje;
        private bool czyRozpatrzona;

        public Reklamacja()
        {

        }

        public Reklamacja(int idReklamowanegoDziału, int liczbaDniNaRealizacje, bool czyRozpatrzona, int IdZglosznia, bool czyOdczytane,bool czyPoinformowanoKlienta)
        {
            this.IdZgloszenia = IdZglosznia;
            this.CzyOdczytane = czyOdczytane;
            this.CzyPoinformowanoKienta = czyPoinformowanoKlienta;
            this.idReklamowanegoDziału = idReklamowanegoDziału;
            this.liczbaDniNaRealizacje = liczbaDniNaRealizacje;
            this.czyRozpatrzona = czyRozpatrzona;
        }

        public string[] TrescOdpowiedzi
        {
            get
            {
                return base.TrescOdpowiedzi;
            }
        }

        public void WpiszTresc()
        {
            //Odbiór informacji z komponentu graficznego i przypisanie do pól klasy
            Console.WriteLine("Pobieranie treści zgłoszenia nr " + IdZgloszenia + " z interfejsu.");
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

        public int IdReklamowanegoDziału
        {
            get
            {
                return idReklamowanegoDziału;
            }

            set
            {
                idReklamowanegoDziału = value;
            }
        }

        public int LiczbaDniNaRealizacje
        {
            get
            {
                return liczbaDniNaRealizacje;
            }

            set
            {
                liczbaDniNaRealizacje = value;
            }
        }

        public bool CzyRozpatrzona
        {
            get
            {
                return czyRozpatrzona;
            }

            set
            {
                czyRozpatrzona = value;
            }
        }

        public int PozostałyCzasRealizacji()
        {
            return liczbaDniNaRealizacje;
        }

        public void WyślijDoDziału( int idDzialu, int idZgloszenia)
        {
            //Wysłanie zgłoszenia na skrzynke pocztowa szefa działału
            foreach (Zgłoszenia zgloszenie in MenedzerZgloszen.bazaZgloszen)
            {
                if (zgloszenie.IdZgloszenia == idZgloszenia)
                {
                    Console.WriteLine("Wysyłanie reklamacji nr " + IdZgloszenia + "do działu nr "+ idDzialu);
                }
                else
                {
                    Console.WriteLine("Reklamacja o nr " + IdZgloszenia + " nie istnieje w bazie.");
                }
            }

        }
        public void RozpatrzenieReklamacji( int idZgloszenia)
        {
            foreach (Zgłoszenia zgloszenie in MenedzerZgloszen.bazaZgloszen)
            {
                if (zgloszenie.IdZgloszenia == idZgloszenia )
                {
                    Console.WriteLine("Pobieranie treści reklamacji nr " + IdZgloszenia + "\n pobieranie......");
                    Console.WriteLine("Czy pozytywnie rozpatrzyć reklamacje <t/n> " + IdZgloszenia);
                    string resultatReklamcji = Console.ReadLine();
                    bool resultatReklamcjiBool = false;
                    if (resultatReklamcji == "t")
                    {
                        resultatReklamcjiBool = true;
                    }
                    else
                    {
                        resultatReklamcjiBool = false;
                    }
                }
                else
                {
                    Console.WriteLine("Reklamacja o nr " + IdZgloszenia + " nie istnieje w bazie.");
                }
            }
        }

    }
}
