using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgettoRistorante
{
    public partial class Gestore : Form
    {
        public Gestore()
        {
            InitializeComponent();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gestore_Load(object sender, EventArgs e)
        {

        }

        private void indietro1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void pulsanteAvantiPassword_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == leggi(@"Password.csv"))
            {
                bottoneAggiunta.Visible = true;
                bottoneVisualizza.Visible = true;
                bottoneRicerca.Visible = true;
                bottoneElimina.Visible = true;
                bottoneModifica.Visible = true;
                passwordTextBox.Visible = false;
                pulsanteAvantiPassword.Visible = false;
                labelAccesso.Visible = false;
            }
        }
        public static string leggi(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line="";
            if((line = sr.ReadLine()) != null)
            {
                sr.Close(); 
            }
            return line;
        }

        private void bottoneAggiunta_Click(object sender, EventArgs e)
        {
            Aggiunta agg = new Aggiunta();
            this.Hide();
            agg.ShowDialog();
            this.Close();
        }
    }
}
