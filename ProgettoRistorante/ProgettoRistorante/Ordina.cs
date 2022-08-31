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
    public partial class Ordina : Form
    {
        Form1.Piatto[] piatti = new Form1.Piatto[100];
        Form1.Piatto[] antipasti = new Form1.Piatto[100];
        Form1.Piatto[] primi = new Form1.Piatto[100];
        Form1.Piatto[] secondi = new Form1.Piatto[100];
        Form1.Piatto[] dessert = new Form1.Piatto[100];
        int contAntipasti = 0;
        int contPrimi = 0;
        int contSecondi = 0;
        int contDessert = 0;
        public Ordina()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientiBox.Text = string.Empty;
            prezzoBox.Text = string.Empty;
            for (int i = 0; i < piatti.Length; i++)
            {
                if (piattiBox.Text == piatti[i].nome)
                {
                    prezzoBox.Text = piatti[i].prezzo;
                    for (int j = 0; j < piatti[i].ingredienti.Length; j++)
                    {
                        if (piatti[i].ingredienti[j] != null)
                        {
                            ingredientiBox.Text += piatti[i].ingredienti[j] + "\n";
                        }
                        else break;
                    }
                }
            }
        }
        public static void scriviAppend(string filename, string content)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }
        public static void leggi(string filename, Form1.Piatto[] piatti)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "//")
                {
                    line = sr.ReadLine();
                    while (line != "//")
                    {
                        line = sr.ReadLine();
                    }
                    line = sr.ReadLine();
                }
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

        private void Ordina_Load(object sender, EventArgs e)
        {
            leggi(@"Menu.csv", piatti);
            FiltraPiatti(piatti, antipasti, primi, secondi, dessert, ref contAntipasti, ref contPrimi, ref contSecondi, ref contDessert);
            for (int i = 0; i < piatti.Length; i++)
            {
                if (piatti[i].nome != null)
                {
                    piattiBox.Items.Add(piatti[i].nome);
                }
                else break;
            }

        }

        private static void FiltraPiatti(Form1.Piatto[] piatti, Form1.Piatto[] antipasti, Form1.Piatto[] primi, Form1.Piatto[] secondi, Form1.Piatto[] dessert, ref int contAntipasti, ref int contPrimi, ref int contSecondi, ref int contDessert)
        {

            for (int i = 0; i < piatti.Length; i++)
            {
                if (piatti[i].portata == "Antipasto")
                {
                    antipasti[contAntipasti] = piatti[i];
                    contAntipasti++;
                }
                if (piatti[i].portata == "Primo")
                {
                    primi[contPrimi] = piatti[i];
                    contPrimi++;
                }
                if (piatti[i].portata == "Secondo")
                {
                    secondi[contSecondi] = piatti[i];
                    contSecondi++;
                }
                if (piatti[i].portata == "Dessert")
                {
                    dessert[contDessert] = piatti[i];
                    contDessert++;
                }
            }
        }

        private void tuttiButton_Click(object sender, EventArgs e)
        {
            ingredientiBox.Text = string.Empty;
            prezzoBox.Text = string.Empty;
            piattiBox.Items.Clear();
            for (int i = 0; i < piatti.Length; i++)
            {
                if (piatti[i].nome != null)
                {
                    piattiBox.Items.Add(piatti[i].nome);
                }
                else break;
            }
        }

        private void antipastiButton_Click(object sender, EventArgs e)
        {
            ingredientiBox.Text = string.Empty;
            prezzoBox.Text = string.Empty;
            piattiBox.Items.Clear();
            for (int i = 0; i < contAntipasti; i++)
            {
                if (antipasti[i].nome != null)
                {
                    piattiBox.Items.Add(antipasti[i].nome);
                }
                else break;
            }
        }

        private void primiButton_Click(object sender, EventArgs e)
        {
            ingredientiBox.Text = string.Empty;
            prezzoBox.Text = string.Empty;
            piattiBox.Items.Clear();
            for (int i = 0; i < contPrimi; i++)
            {
                if (primi[i].nome != null)
                {
                    piattiBox.Items.Add(primi[i].nome);
                }
                else break;
            }
        }

        private void secondiButton_Click(object sender, EventArgs e)
        {
            ingredientiBox.Text = string.Empty;
            prezzoBox.Text = string.Empty;
            piattiBox.Items.Clear();
            for (int i = 0; i < contSecondi; i++)
            {
                if (secondi[i].nome != null)
                {
                    piattiBox.Items.Add(secondi[i].nome);
                }
                else break;
            }
        }

        private void dessertButton_Click(object sender, EventArgs e)
        {
            ingredientiBox.Text = string.Empty;
            prezzoBox.Text = string.Empty;
            piattiBox.Items.Clear();
            for (int i = 0; i < contDessert; i++)
            {
                if (dessert[i].nome != null)
                {
                    piattiBox.Items.Add(dessert[i].nome);
                }
                else break;
            }
        }

        private void confermaButton_Click(object sender, EventArgs e)
        {
            if (piattiBox.Text != string.Empty)
            {
                for (int i = 0; i < piatti.Length; i++)
                {
                    if (piatti[i].nome == piattiBox.Text)
                    {
                        scriviAppend(@"Ordine.csv", ToString(piatti[i]));
                    }
                }
                piattiBox.Text = string.Empty;
                ingredientiBox.Text = string.Empty;
                prezzoBox.Text = string.Empty;
            }
            else MessageBox.Show("Selezionare un piatto prima di confermare");
            

        }
        private string ToString(Form1.Piatto piatto)
        {
            string piattoFile = $"Nome:\n{piatto.nome}\nPrezzo:\n{piatto.prezzo}\nIngredienti:\n";
            for (int i = 0; i < piatto.ingredienti.Length; i++)
            {
                if (piatto.ingredienti[i] != null)
                {
                    piattoFile += piatto.ingredienti[i] + "\n";
                }
                else break;
            }
            piattoFile += $"Portata:\n{piatto.portata}\n;";
            return piattoFile;
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            this.Hide();
            cli.ShowDialog();
            this.Close();
        }
    }
}

