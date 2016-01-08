using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PrzelewyKontroler
    {
        public bool wyslijPrzelew(String numer, String daneOdbiorcy, String tytul,  String kwota){

           //TODO - podpiac interfejs ktory udostepni modul transakcje
            Console.WriteLine("numer: " + numer + " daneOdbiorcy: " + daneOdbiorcy + 
                " kwota: " + kwota + " tytul: " + tytul );
            int kwotaInt;
            if (kwota == null) return false;
            try {
                kwotaInt = Convert.ToInt32(kwota);
            }
            catch (FormatException) { return false; }
         
            if (kwotaInt < 5000) //5000 jako gorne ograniczenie 
                return true;
            return false;
         }
    }
}
