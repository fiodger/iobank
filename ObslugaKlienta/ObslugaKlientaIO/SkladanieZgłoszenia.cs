using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class SkladanieZgłoszenia
    {
        private int idZgloszenia;
        private int idKlienta;
        private string dataZgloszenia;
        private string trescZgloszenia;

        public enum TypZgloszenia
        {
            zero,
            informacyjne,
            skarga,
            reklamacjyjne,
            zapytanie
        };

        public SkladanieZgłoszenia(int idKlienta, string dataZgloszenia)
        {
            this.idZgloszenia = GenerujIdZgłoszenia();
            this.idKlienta = idKlienta;
            this.dataZgloszenia = dataZgloszenia;
            
        }

        public SkladanieZgłoszenia()
        {
            
        }

        public int IdZgloszenia
        {
            get
            {
                return idZgloszenia;
            }
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

        public string DataZgloszenia
        {
            get
            {
                return dataZgloszenia;
            }

            set
            {
                dataZgloszenia = value;
            }
        }

        public string TrescZgloszenia
        {
            get
            {
                return trescZgloszenia;
            }

            set
            {
                trescZgloszenia = value;
            }
        }

        public void WypełnijZgłoszenie()
        {
            Console.WriteLine("Wybierz typ zgloszenia (1- informacja, 2- skarga, 3-reklamacja, 4-zapytanie) ");
            string typZgloszenia = Console.ReadLine();
            int rozmiar = int.Parse(typZgloszenia);

            switch (rozmiar)
            {
                case (int)TypZgloszenia.informacyjne:
                    {
                        Informacja tymczasowe = new Informacja(idZgloszenia, false, false);
                        Console.WriteLine("Podaj tresc zgloszenia: ");
                        tymczasowe.WpiszTresc();
                        MenedzerZgloszen.NoweZgłoszenie(tymczasowe);
                        break;
                    }
                case (int)TypZgloszenia.skarga:
                    {
                        Skarga tymczasowe = new Skarga(1, false, idZgloszenia, false, false);
                        Console.WriteLine("Podaj tresc zgloszenia: ");
                        tymczasowe.WpiszTresc();
                        MenedzerZgloszen.NoweZgłoszenie(tymczasowe);
                        break;
                    }
                case (int)TypZgloszenia.reklamacjyjne:
                    {
                        Reklamacja tymczasowe = new Reklamacja(1, 7, false, idZgloszenia, false, false);
                        Console.WriteLine("Podaj tresc zgloszenia: ");
                        tymczasowe.WpiszTresc();
                        MenedzerZgloszen.NoweZgłoszenie(tymczasowe);
                        break;
                    }
                case (int)TypZgloszenia.zapytanie:
                    {
                        Zapytanie tymczasowe = new Zapytanie(idZgloszenia, false, false);
                        Console.WriteLine("Podaj tresc zgloszenia: ");
                        tymczasowe.WpiszTresc();
                        MenedzerZgloszen.NoweZgłoszenie(tymczasowe);
                        break;
                    }
            }
        }

        private int GenerujIdZgłoszenia()
        {
            return new Random().Next(0, 2000);
        }
    }
}
