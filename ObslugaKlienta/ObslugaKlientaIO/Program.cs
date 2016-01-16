using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pomoc pomocSystemowa = new Pomoc();

            MenedzerZgloszen menedzer = new MenedzerZgloszen();
            Klient klient = new Klient(1);

            Pracownik pracownik_1 = new Pracownik(1);
            Pracownik pracownik_2 = new Pracownik(2);

            FAQ noweFAQ = new FAQ();

            Administrator administrator = new Administrator(1,noweFAQ);

            //Skladanie zgloszenia przez Klienta -caly proces
            Console.WriteLine("OBSŁUGA KLIENTA ( naciśnij 'o' aby rozpoczać )");
            string kontynuacja = Console.ReadLine();


            while( kontynuacja == "o")
            {
                Console.Clear();
                Console.WriteLine("Wybierz działanie: FAQ[f], zgloszenia[z], pomoc[p], wyjscie[w] ");
                string dzialnie = Console.ReadLine();

                if (dzialnie == "f")
                {
                    Console.WriteLine("FAQ - pracownik [p], klient [k], administrator[a], gosc[g]");
                    string uzytkownik = Console.ReadLine();
                    if (uzytkownik == "k")
                    {
                        Console.WriteLine("Czy chcesz dodac pytanie do FAQ ? <t/n>");
                        string dodacDoFAQ = Console.ReadLine();
                        if (dodacDoFAQ == "t")
                        {
                            klient.DodajPytanieDoFAQ(noweFAQ);
                        }
                        Console.WriteLine("Wyswietl pytania ? <t/n>");
                        string wyswietlFAQ = Console.ReadLine();
                        if (wyswietlFAQ == "t")
                        {
                            noweFAQ.WyswietlPytania();
                        }
                    }
                    else
                    {
                        if (uzytkownik == "p")
                        {
                            Console.WriteLine("Czy chcesz dodac pytanie do FAQ ? <t/n>");
                            string dodacDoFAQ = Console.ReadLine();
                            if (dodacDoFAQ == "t")
                            {
                                noweFAQ.DodajPytanieDoFAQ(pracownik_1.IdPracownika);
                            }
                            Console.WriteLine("Wyswietl pytania ? <t/n>");
                            string wyswietlFAQ = Console.ReadLine();
                            if (wyswietlFAQ == "t")
                            {
                                noweFAQ.WyswietlPytania();
                            }
                        }
                        else
                        {
                            if (uzytkownik == "a")
                            {
                                Console.WriteLine("Czy zatwierdzic propozycje/dodac pytania do bazy glownej ? <t/n>");
                                string zatwierdzFAQ = Console.ReadLine();
                                if (zatwierdzFAQ == "t")
                                {
                                    administrator.PotwierdzPytania();
                                }
                                Console.WriteLine("Wyswietl pytania ? <t/n>");
                                string wyswietlFAQ = Console.ReadLine();
                                if (wyswietlFAQ == "t")
                                {
                                    noweFAQ.WyswietlPytania();
                                }
                                Console.WriteLine("Czy usunac ktores pytanie ? <t/n>");
                                string usun = Console.ReadLine();
                                if (usun == "t")
                                {
                                    Console.WriteLine("Podaj tresc pytania do usuniecia: ");
                                    administrator.UsunPytanie(Console.ReadLine());
                                }
                            }
                            else
                            {
                                if( uzytkownik == "g")
                                {
                                    Console.WriteLine("Wyswietl pytania ? <t/n>");
                                    string wyswietlFAQ = Console.ReadLine();
                                    if (wyswietlFAQ == "t")
                                    {
                                        noweFAQ.WyswietlPytania();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (dzialnie == "z")
                    {
                        klient.Zgloszenie();
                        menedzer.WyswietlZdarzenia();

                        Console.WriteLine("Numer zgloszenia do procesu rozpatrzenia ");
                        string numerZgloszenia = Console.ReadLine();
                        int numer = int.Parse(numerZgloszenia);

                        pracownik_1.RozpatrzZgloszenie(numer);
                        pracownik_1.OdpowiedzKlientowi(numer);

                        Console.WriteLine("Czy zatwierdzic <ADMINISTRATOR> (t/n) ");
                        string decyzja = Console.ReadLine();
                        if (decyzja == "t")
                        {
                            administrator.ZatwierdźZgłoszenie(numer);
                        }

                        pracownik_1.OdpowiedzKlientowi(numer);

                        menedzer.ArchiwizujWBazie();
                    }
                    else
                    {
                        if (dzialnie == "p")
                        {
                            pomocSystemowa.WyswietlPomoc();
                        }
                        else
                        {
                            if (dzialnie == "w")
                            {
                                kontynuacja = " ";
                            }
                        }
                    }
                }

                Console.ReadKey();
            }

            Console.WriteLine("Konczenie...");
            Console.ReadKey();

        }
    }
}
