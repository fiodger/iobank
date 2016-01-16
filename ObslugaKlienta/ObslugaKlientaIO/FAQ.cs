using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class FAQ
    {
        private int liczbaPytań;
        public static List<string> propozycjePytan;
        private List<string> pytania;



        public FAQ()
        {
            liczbaPytań = 0;
            propozycjePytan = new List<string>();
            pytania = new List<string>();
        }

        public void WyswietlPytania()
        {
            Console.WriteLine("Baza posiada "+ liczbaPytań+" pytani/a.");
            foreach (string pytanie in pytania)
            {
                Console.WriteLine(pytanie);
            }
        }

        public void ZatwierdzPropozycjePytanFAQ( int idAdministratora)
        {
            Console.WriteLine("Zatwierdzanie propozycji pytan do bazy FAQ przez administratora o nr " + idAdministratora);
            foreach ( string pytanie in propozycjePytan)
            {
                liczbaPytań++;
                pytania.Add(pytanie);
            }
            propozycjePytan.Clear();
        }

        public void DodajPytanieDoFAQ(int idPracownika)
        {
            Console.WriteLine("Dodanie pytania do FAQ przez pracownika o nr " + idPracownika);
            Console.WriteLine("Podaj tresc pytania");
            pytania.Add(Console.ReadLine());
            liczbaPytań++;
            Console.WriteLine("Pytanie zostalo dodane");
        }

        public int LiczbaPytań
        {
            get
            {
                return liczbaPytań;
            }

            set
            {
                liczbaPytań = value;
            }
        }

        public List<string> Pytania
        {
            get
            {
                return pytania;
            }

            set
            {
                pytania = value;
            }
        }
    }
}
