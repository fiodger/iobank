using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class Pomoc
    {
        public static List<string> pomoc;

        public Pomoc()
        {
            pomoc = new List<string>();
            pomoc.Add("Pomoc bedzie przechowywana w pliku tekstowy i wczytywana do systemu.");
        }

        public void WyswietlPomoc()
        {
            foreach (string pytanie in pomoc)
            {
                Console.WriteLine(pytanie);
            }
        }
    }
}
