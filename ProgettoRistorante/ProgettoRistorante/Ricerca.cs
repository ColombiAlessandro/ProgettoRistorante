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
    public partial class Ricerca : Form
    {
        public Ricerca()
        {
            InitializeComponent();
        }

        private void Ricerca_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string piatto = leggi(@"Menu.csv", nomePiatto.Text);
            if (piatto != string.Empty)
            {
                risultatoTextBox.Text = piatto;
                risultatoTextBox.Visible = true;
            } else
            {
                MessageBox.Show("Piatto non trovato");
                nomePiatto.Text = string.Empty;
            }
        }
        public static string leggi(string filename, string ricerca)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            string piatto="Nome:";
            bool isFound=false;
            
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "//")
                {
                    line = sr.ReadLine();
                    while (line != "//")
                    {
                        line = sr.ReadLine();
                    }
                }
                if (line == ricerca) 
                {
                    isFound = true;
                }
                if (isFound)
                {
                    if (line != "Nome:")
                    {
                        piatto += $"\n{line}";
                    } else
                    {
                        return piatto;
                    }
                }
            }

            sr.Close();
            if (!isFound)
            {
                piatto = string.Empty;
            }
            return piatto;
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            Gestore ges = new Gestore();
            this.Hide();
            ges.ShowDialog();
            this.Close();
        }
    }
}
