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
        int cont = 0;
        public VisualizzaTOT()
        {
            InitializeComponent();
        }
        
        private void tuttiBottone_Click(object sender, EventArgs e)
        {
            string line = "";
            for (int j = 0; j < cont; j++)
            {
                line += "Nome:";
                line += "\n" + piatti[j].nome;
                line += "\n" + piatti[j].prezzo;
                for (int i = 0; i < piatti[j].ingredienti.Length; i++)
                {
                    if (piatti[j].ingredienti[i] != null)
                    {
                        line += "\n" + piatti[j].ingredienti[i];
                    }
                }
                line += "\n" + piatti[j].portata;
            }
            risultato.Text = line;
        }

        private void antipastiBottone_Click(object sender, EventArgs e)
        {

        }

        private void primiBottone_Click(object sender, EventArgs e)
        {

        }

        private void secondiBottone_Click(object sender, EventArgs e)
        {

        }

        private void dessertBottone_Click(object sender, EventArgs e)
        {

        }
        public static Form1.Piatto[] leggiTot(string filename, Form1.Piatto[] piatti, ref int cont)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            line=sr.ReadToEnd();
            string[] tmp = line.Split('\n');
            for(int i=0; i < tmp.Length; i++)
            {
                if (tmp[i] == "Nome:\r")
                {
                    piatti[cont].nome = tmp[i + 1];
                }
                if (tmp[i] == "Prezzo:\r")
                {
                    piatti[cont].prezzo = $"Prezzo:\n{tmp[i + 1]}";
                }
                if(tmp[i]== "Ingredienti:\r")
                {
                    int tmp2=1;
                    piatti[cont].ingredienti = new string[100];
                    piatti[cont].ingredienti[0] = "Ingredienti:";
                    while (tmp[i] != "Portata:\r")
                    {
                        piatti[cont].ingredienti[tmp2] = tmp[i];
                        tmp2++;
                        i++;
                    }
                }
                if (tmp[i] == "Portata:\r")
                {
                    piatti[cont].portata = $"Portata:\n{tmp[i + 1]}";
                }
                if (tmp[i] == ";\r")
                {
                    cont++;
                }
            }
            return piatti;
            sr.Close();
        }

        private void VisualizzaTOT_Load(object sender, EventArgs e)
        {
            piatti=leggiTot(@"Menu.csv", piatti, ref cont);
        }
        private Form1.Piatto [] filtroPortata(Form1.Piatto[]piatti, string portata, int cont)
        {
            Form1.Piatto[] piattiFiltrati = new Form1.Piatto[cont];
            int contFiltro = 0;
            for(int i=0; i<cont; i++)
            {
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
    }
}
