using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class Administrator : Pracownik
    {
        private int idAdministratora;
        private FAQ bazaFAQ;

        public Administrator(int idAdministratora, FAQ noweFAQ)
        {
            this.idAdministratora = idAdministratora;
            this.bazaFAQ = noweFAQ;
        }

        public int IdAdministratora
        {
            get
            {
                return idAdministratora;
            }

            set
            {
                idAdministratora = value;
            }
        }

        public void PotwierdzPytania()
        {
            if( FAQ.propozycjePytan.Count() != 0)
            {
                bazaFAQ.ZatwierdzPropozycjePytanFAQ(this.idAdministratora);
            }
            else
            {
                Console.WriteLine("Brak pytan do zatwierdzenia.");
            }
        }

        public void UsunPytanie( string tresc)
        {
            if (bazaFAQ.Pytania.Count() != 0)
            {
                bazaFAQ.Pytania.Remove(tresc);
                bazaFAQ.LiczbaPytań--;
                Console.WriteLine("Pytanie zostalo usuniete.");
            }
            else
            {
                Console.WriteLine("Brak pytania w bazie.");
            }
        }

        public void ZatwierdźZgłoszenie(int idZgloszenia)
        {
            foreach( Zgłoszenia zgloszenie in MenedzerZgloszen.bazaZgloszen)
            {
                if( zgloszenie.IdZgloszenia == idZgloszenia && zgloszenie.ZatwierdzonePrzezAdministratora == false)
                {
                    Console.WriteLine("Administrator zatwierdzil zgloszenie o numerze " + zgloszenie.IdZgloszenia);
                    zgloszenie.ZatwierdzonePrzezAdministratora = true;
                    zgloszenie.IdAdministratora = idAdministratora;
                }
            }
        }
    }
}
