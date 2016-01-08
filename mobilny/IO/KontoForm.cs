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
    public partial class KontoForm : Form
    {   
        private LoginForm loginForm;
        private PrzelewyForm przelewyForm;
        
        public KontoForm()
        {
            InitializeComponent();
            loginForm = new LoginForm();
      
          
        }

        private void KontoForm_Load(object sender, EventArgs e)
        {
            ustawInformacje();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ustawInformacje()
        {
            //TO-DO podpiąć interfejs modułu konto
            ImieWartosc.Text = "Jan";
            nazwiskoWartosc.Text = "Kowalski";
            AdresWartosc.Text = "Łódzka 30, 00-000 Warszawa";
            TelefonWartosc.Text = "26 668 111 841";
            NumerKontaWartosc.Text = "26 1111 2222 3333 4444 5555 6666";
            StatusWartosc.Text = "aktywne";
            SaldoWartosc.Text = "21 370 PLN";
        }

        private void wyloguj(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void pomoc(object sender, EventArgs e)
        {   
            PomocForm pomocForm   = new PomocForm();
            this.Hide();
            pomocForm.ShowDialog();
            this.Close();
        }

        private void transakcje(object sender, EventArgs e)
        {
           przelewyForm = new PrzelewyForm(); 
           this.Hide();
           przelewyForm.ShowDialog();
           this.Close();
         
        }
    }
}
