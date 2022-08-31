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
    public partial class Scontrino : Form
    {
        Form1.Piatto[] piatti = new Form1.Piatto[100];
        public Scontrino()
        {
            InitializeComponent();
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            this.Hide();
            cli.ShowDialog();
            this.Close();
        }
        public static void leggi(string filename, Form1.Piatto[] piatti)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "Nome:")
                {
                    line = sr.ReadLine();
                    piatti[i].nome = line;
                }
                if (line == "Prezzo:")
                {
                    line = sr.ReadLine();
                    piatti[i].prezzo = line;
                }
                if (line == "Ingredienti:")
                {
                    int j = 0;
                    piatti[i].ingredienti = new string[100];
                    while ((line = sr.ReadLine()) != "Portata:")
                    {
                        piatti[i].ingredienti[j] = line;
                    }
                }
                if (line == "Portata:")
                {
                    line = sr.ReadLine();
                    piatti[i].portata = line;
                }
                if (line == ";")
                {
                    i++;
                }
            }

            sr.Close();
        }
        private void Scontrino_Load(object sender, EventArgs e)
        {
            leggi(@"Ordine.csv", piatti);
            float prezzo = 0;
            for(int i = 0; i < piatti.Length; i++)
            {
                if (piatti[i].nome != null)
                {
                    scontrinoBox.Text += piatti[i].nome + "\n";
                    prezzo += float.Parse(piatti[i].prezzo);
                } else
                {
                    break;
                }
            }
            PrezzoBox.Text = prezzo.ToString()+"€";

        }

        private void dettagliButton_Click(object sender, EventArgs e)
        {
            indietroDettagli.Visible = true;
            scontrinoBox.Text = string.Empty;
            for (int i = 0; i < piatti.Length; i++)
            {
                if (piatti[i].nome != null)
                {
                    scontrinoBox.Text += $"Nome:\n{piatti[i].nome}\nPrezzo:\n{piatti[i].prezzo}\nIngredienti:\n";
                    for (int j = 0; j < piatti[i].ingredienti.Length; j++)
                    {
                        if (piatti[i].ingredienti[j] != null)
                        {
                            scontrinoBox.Text += piatti[i].ingredienti[j] + "\n";
                        }
                        else break;

                    }
                    scontrinoBox.Text += $"Portata:\n{piatti[i].portata}\n";
                }
                else break;
            }
        }

        private void indietroDettagli_Click(object sender, EventArgs e)
        {
            scontrinoBox.Text = string.Empty;
            for (int i = 0; i < piatti.Length; i++)
            {
                if (piatti[i].nome != null)
                {
                    scontrinoBox.Text += piatti[i].nome + "\n";
                }
                else
                {
                    break;
                }
            }
            indietroDettagli.Visible = false;
        }
    }
}
