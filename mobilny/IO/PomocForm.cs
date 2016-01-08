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
    public partial class PomocForm : Form
    {
        private GlownyKontroler kontroler;
        private KontoForm kontoForm;
        private LoginForm loginForm;
        public PomocForm()
        {
            kontroler = new GlownyKontroler();
            kontoForm = new KontoForm();
            loginForm = new LoginForm();
            InitializeComponent();
        }

        private void wyloguj(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void mojeKonto(object sender, EventArgs e)
        {
            this.Hide();
            kontoForm.ShowDialog();
            this.Close();
        }

        private void wyslij(object sender, EventArgs e)
        {  
            kontroler.przekazDoPomocKontroler(pomocEditBox.Text);
            this.sukces.Visible = true; 

        }

     
    }
}
