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
    public partial class LoginForm : Form
    {   
        private GlownyKontroler kontroler;

        public LoginForm()
        {
            InitializeComponent();
            kontroler = new GlownyKontroler();
          
          
        }


        private void zaloguj(object sender, EventArgs e)
        {
            Console.WriteLine("Login: " + loginEditBox.Text + " Haslo" + passwordEditBox.Text);
            if (kontroler.przekazDoLoginKontroler(loginEditBox.Text, passwordEditBox.Text))
            {
                niepoprawny.Visible = true;
            }
            else
            {
                niepoprawny.Visible = false;              
                this.Hide();
                KontoForm kontoForm = new KontoForm();
                kontoForm.ShowDialog();
                this.Close();
            }
          
        }

    }
}
