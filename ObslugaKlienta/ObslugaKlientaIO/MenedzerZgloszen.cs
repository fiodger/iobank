using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class MenedzerZgloszen
    {
        private int idPracownika;
        public static List<Zgłoszenia> bazaZgloszen;

        public MenedzerZgloszen()
        {
            bazaZgloszen = new List<Zgłoszenia>();
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

        public void ArchiwizujWBazie()
        {
            Console.WriteLine("Archiwizacja w bazie...");
        }

        public void WyswietlZdarzenia()
        {
            Console.WriteLine("ID wszystkich zgloszen : \n");
       
            foreach (Zgłoszenia zgloszenie in MenedzerZgloszen.bazaZgloszen)
            {
                Console.WriteLine(zgloszenie.IdZgloszenia +"  "+ zgloszenie.TrescOdpowiedzi);
            }
        }

        public static void NoweZgłoszenie(Zgłoszenia zgloszenie)
        {
            Console.WriteLine("Przyjecie nowego "+ zgloszenie.ToString()+ " o nr:  " + zgloszenie.IdZgloszenia);

            bazaZgloszen.Add(zgloszenie);
        }

        public void ModyfikujZgłoszenie(Zgłoszenia zgloszenie)
        {
            Console.WriteLine("MODYFIKAJCA ZGŁOSZENIA NR: " + zgloszenie.IdZgloszenia);

        }

        public void UsunZgłoszenie(Zgłoszenia zgloszenie)
        {
            Console.WriteLine("Usuwanie zgłoszenia nr: " + zgloszenie.IdZgloszenia);

            bazaZgloszen.Remove(zgloszenie);
        }

    }
}
