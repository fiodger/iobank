using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaKlientaIO
{
    public abstract class Zgłoszenia
    {
        private bool czyPoinformowanoKienta;
        private int idZgloszenia;
        private bool czyOdczytane;
        private string[] trescOdpowiedzi;
        private bool zatwierdzonePrzezAdministratora;
        private int idAdministratora;

        public bool CzyPoinformowanoKienta
        {
            get
            {
                return czyPoinformowanoKienta;
            }

            set
            {
                czyPoinformowanoKienta = value;
            }
        }

        public int IdZgloszenia
        {
            get
            {
                return idZgloszenia;
            }

            set
            {
                idZgloszenia = value;
            }
        }

        public bool CzyOdczytane
        {
            get
            {
                return czyOdczytane;
            }

            set
            {
                czyOdczytane = value;
            }
        }

        public string[] TrescOdpowiedzi
        {
            get
            {
                return trescOdpowiedzi;
            }

            set
            {
                trescOdpowiedzi = value;
            }
        }

        public bool ZatwierdzonePrzezAdministratora
        {
            get
            {
                return zatwierdzonePrzezAdministratora;
            }

            set
            {
                zatwierdzonePrzezAdministratora = value;
            }
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
    }
}
