using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class Klient
    {
        private int idKlienta;

        public Klient(int idKlienta)
        {
            this.idKlienta = idKlienta;
        }

        public int IdKlienta
        {
            get
            {
                return idKlienta;
            }

            set
            {
                idKlienta = value;
            }
        }

        public void Zgloszenie()
        {
            SkladanieZgłoszenia zgloszenie = new SkladanieZgłoszenia(idKlienta, "22-02-2015");
            zgloszenie.WypełnijZgłoszenie();
        }

        public void DodajPytanieDoFAQ( FAQ daneFAQ)
        {
            Console.WriteLine("Dodawanie pytania do FAQ. Podaj tresc pytania");
            FAQ.propozycjePytan.Add(Console.ReadLine());
            daneFAQ.LiczbaPytań = daneFAQ.LiczbaPytań++;
            Console.WriteLine("Pytanie zostalo dodane, teraz bedzie oczekiwac na zatwierdzenie przez administatora");
        }
    }
}
