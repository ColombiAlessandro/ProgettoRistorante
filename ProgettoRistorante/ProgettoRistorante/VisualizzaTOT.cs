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
    
    public partial class VisualizzaTOT : Form
    {
        Form1.Piatto[] piatti = new Form1.Piatto[100];
        Form1.Piatto[] piattiFiltro = new Form1.Piatto[100];
        Form1.Piatto piattoVuoto = new Form1.Piatto();
        int cont = 0;
        int contFiltro=0;
        public VisualizzaTOT()
        {
            InitializeComponent();
        }
        
        private void tuttiBottone_Click(object sender, EventArgs e)
        {
            risultato.Text = string.Empty;
            risultato.Text = ToString(piatti, cont);
        }

        private void antipastiBottone_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < cont; i++)
            {
                piattiFiltro[i] = piattoVuoto;
            }
            risultato.Text = string.Empty;
            piattiFiltro = filtroPortata(piatti, "Portata:\r\nAntipasto\r\n", ref cont, ref contFiltro);
            if (contFiltro > 0)
                risultato.Text = ToString(piattiFiltro, contFiltro);
                
        }

        private void primiBottone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cont; i++)
            {
                piattiFiltro[i] = piattoVuoto;
            }
            risultato.Text = string.Empty;
            piattiFiltro = filtroPortata(piatti, "Portata:\r\nPrimo\r\n", ref cont, ref contFiltro);
            if (contFiltro > 0)
                risultato.Text = ToString(piattiFiltro, contFiltro);
        }

        private void secondiBottone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cont; i++)
            {
                piattiFiltro[i] = piattoVuoto;
            }
            risultato.Text = string.Empty;
            piattiFiltro = filtroPortata(piatti, "Portata:\r\nSecondo\r\n", ref cont, ref contFiltro);
            if (contFiltro > 0)
                risultato.Text = ToString(piattiFiltro, contFiltro);
        }

        private void dessertBottone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cont; i++)
            {
                piattiFiltro[i] = piattoVuoto;
            }
            risultato.Text = string.Empty;
            piattiFiltro = filtroPortata(piatti, "Portata:\r\nDessert\r\n", ref cont, ref contFiltro);
            if (contFiltro > 0)
                risultato.Text = ToString(piattiFiltro, contFiltro);
        }
        public Form1.Piatto[] leggiTot(string filename, Form1.Piatto[] piatti, ref int cont)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            line=sr.ReadToEnd();
            string[] tmp = line.Split('\n');
            for(int i=0; i < tmp.Length; i++)
            {
                if (tmp[i] == "//\r")
                {
                    i++;
                    while (tmp[i] != "//\r")
                    {
                        i++;
                    }
                    i++;
                }
                if (tmp[i] == "Nome:\r")
                {
                    piatti[cont].nome = $"Nome:\r\n{tmp[i + 1]}\n";
                }
                if (tmp[i] == "Prezzo:\r")
                {
                    piatti[cont].prezzo = $"Prezzo:\r\n{tmp[i + 1]}\n";
                }
                if (tmp[i] == "Ingredienti:\r")
                {
                    int tmp2 = 1;
                    i++;
                    piatti[cont].ingredienti = new string[100];
                    piatti[cont].ingredienti[0] = "Ingredienti:\r";
                    while (tmp[i] != "Portata:\r")
                    {
                        piatti[cont].ingredienti[tmp2] = tmp[i]+"\n";
                        tmp2++;
                        i++;
                    }
                }
                if (tmp[i] == "Portata:\r")
                {
                    piatti[cont].portata = $"Portata:\r\n{tmp[i + 1]}\n";
                }
                if (tmp[i] == ";\r")
                {
                    risultato.Text += "\n";
                    cont++;
                }
            }
            sr.Close();
            return piatti;
            
        }

        private void VisualizzaTOT_Load(object sender, EventArgs e)
        {
            piattiFiltro[0].nome = string.Empty;
            piatti=leggiTot(@"Menu.csv", piatti, ref cont);
        }
        private Form1.Piatto [] filtroPortata(Form1.Piatto[]piatti, string portata, ref int cont, ref int contFiltro)
        {
            Form1.Piatto [] piattiFiltrati = new Form1.Piatto[cont];
            contFiltro = 0;
            for(int i=0; i<cont; i++)
            {
                piattiFiltrati[i].ingredienti = new string[100];
                if (piatti[i].portata == portata)
                {
                    piattiFiltrati[contFiltro] = piatti[i];
                    contFiltro++;
                }
            }
            return piattiFiltrati;
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            Gestore ges = new Gestore();
            this.Hide();
            ges.ShowDialog();
            this.Close();
        }
        private string ToString(Form1.Piatto[]piatti, int cont)
        {
            string line = "";
            for (int j = 0; j < cont; j++)
            {
                line += piatti[j].nome;
                line += piatti[j].prezzo;
                for (int i = 0; i < piatti[j].ingredienti.Length; i++)
                {
                    if (piatti[j].ingredienti[i] != null)
                    {
                        line += piatti[j].ingredienti[i];
                    }
                }
                line += piatti[j].portata;
            }
            return line;
        }
    }
}
