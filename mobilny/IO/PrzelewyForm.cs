using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO
{
    public partial class PrzelewyForm : Form
    {
        public GlownyKontroler glownyKontroler;
        public PrzelewyForm()
        {   
            glownyKontroler = new GlownyKontroler();
            InitializeComponent();
        }
 

        private void przekazDane(object sender, EventArgs e)
        {
            String numer = numerRachunkuWartosc.Text;
            String daneOdbiorcy = nazwaOdbiorcyWartosc.Text;
            String kwota = kwotaWartosc.Text;
            String tytul = tytulWartosc.Text;
            bool wynik =  glownyKontroler.przekazDoPrzelewyKontroler(numer, daneOdbiorcy, tytul, kwota);
            if (wynik)
            {
                this.sukces.Visible = true;
                this.fail.Visible = false;
            }
            else
            {
                this.sukces.Visible = false;
                this.fail.Visible = true;
            }

        }

        private void wyloguj(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }


        private void mojeKonto(object sender, EventArgs e)
        {
            KontoForm kontoForm = new KontoForm();
            this.Hide();
            kontoForm.ShowDialog();
            this.Close();
        }
    }
}
