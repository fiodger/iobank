using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class Pracownik
    {
        private int idPracownika;
        public string adresMailowy;

        public Pracownik()
        {
            
        }

        public Pracownik(int idPracownika)
        {
            this.idPracownika = idPracownika;

        }

        public void RozpatrzZgloszenie( int idZgloszenia)
        {
            foreach (Zgłoszenia zgloszenie in MenedzerZgloszen.bazaZgloszen)
            {
                if (zgloszenie.IdZgloszenia == idZgloszenia)
                {
                    if( zgloszenie.CzyOdczytane == false)
                    {
                        Console.WriteLine("Pracownik o id " + idPracownika + " odczytal zgloszenie nr " + idZgloszenia);
                        zgloszenie.CzyOdczytane = true;
                    }
                    else
                    {
                        Console.WriteLine("Zgloszenie nr " + idZgloszenia+ " jest juz rozpatrzone");
                    }
                }
            }
        }

        public void OdpowiedzKlientowi(int idZgloszenia)
        {
            foreach (Zgłoszenia zgloszenie in MenedzerZgloszen.bazaZgloszen)
            {
                if (zgloszenie.IdZgloszenia == idZgloszenia)
                {
                    if( zgloszenie.ZatwierdzonePrzezAdministratora == true && zgloszenie.CzyPoinformowanoKienta == false)
                    {
                        zgloszenie.CzyPoinformowanoKienta = true;
                        Console.WriteLine("Poinformowano klienta");
                    }
                    else
                    {
                        if (zgloszenie.ZatwierdzonePrzezAdministratora == true && zgloszenie.CzyPoinformowanoKienta == true)
                        {
                            Console.WriteLine("Zgloszenie jest zatwierdzone i klient jest poinformowany");
                        }
                        else
                        {
                            Console.WriteLine("Zgloszenie nie jest zatwierdzone przez administratora");
                        }
                    }
                }
            }
        }

        public string AdresMailowy
        {
            get
            {
                return adresMailowy;
            }

            set
            {
                adresMailowy = value;
            }
        }

        public int IdPracownika
        {
            get
            {
                return idPracownika;
            }

            set
            {
                idPracownika = value;
            }
        }
    }
}
