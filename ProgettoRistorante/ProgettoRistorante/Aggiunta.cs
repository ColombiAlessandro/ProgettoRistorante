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
    public partial class Aggiunta : Form
    {
        public Aggiunta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(String.IsNullOrEmpty(nomeText.Text)) && !(String.IsNullOrEmpty(prezzoText.Text)) && !(String.IsNullOrEmpty(ingredientiText.Text)) && !(String.IsNullOrEmpty(portataBox.Text)) && !(String.IsNullOrWhiteSpace(nomeText.Text)) && !(String.IsNullOrWhiteSpace(prezzoText.Text)) && !(String.IsNullOrWhiteSpace(ingredientiText.Text)))
            {
                if (!nomeText.Text.Contains(';') && !ingredientiText.Text.Contains(';'))
                {
                    try
                    {
                        int.Parse(prezzoText.Text);
                    }
                    catch (Exception ecc)
                    {
                        MessageBox.Show("Prezzo invalido");
                        nomeText.Text = string.Empty;
                        prezzoText.Text = string.Empty;
                        ingredientiText.Text = string.Empty;
                        return;
                    }
                    if (int.Parse(prezzoText.Text) > 0)
                    {
                        scriviAppend(@"Menu.csv", "Nome:");
                        scriviAppend(@"Menu.csv", nomeText.Text);
                        scriviAppend(@"Menu.csv", "Prezzo:");
                        scriviAppend(@"Menu.csv", prezzoText.Text);
                        string[] tmp = ingredientiText.Text.Split('\n');

                        string ingredienti = "";
                        for (int i = 0; i < tmp.Length; i++)
                        {
                            if (i == tmp.Length - 1)
                            {
                                ingredienti += tmp[i];
                                break;
                            }
                            if (tmp[i] != string.Empty)
                            {
                                ingredienti += $"{tmp[i]}\n";
                            }
                        }
                        scriviAppend(@"Menu.csv", "Ingredienti:");
                        scriviAppend(@"Menu.csv", ingredienti);
                        scriviAppend(@"Menu.csv", "Portata:");
                        scriviAppend(@"Menu.csv", portataBox.Text);
                        scriviAppend(@"Menu.csv", ";");
                        MessageBox.Show("Piatto aggiunto");
                        nomeText.Text = string.Empty;
                        prezzoText.Text = string.Empty;
                        ingredientiText.Text = string.Empty;
                        portataBox.Text = portataBox.Items[0].ToString();
                    } else
                    {
                        MessageBox.Show("Il prezzo deve essere maggiore di 0");
                    }
                    
                }
                else
                {
                    MessageBox.Show("I valori inseriti non possono contenere ;");
                }
                
            }
            else
            {
                MessageBox.Show("Uno o più valori non validi");
            }
        }

        private void nomeText_TextChanged(object sender, EventArgs e)
        {
            
        }
        public static void scriviAppend(string filename, string content)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }

        private void indietroBottone_Click(object sender, EventArgs e)
        {
            Gestore gs = new Gestore();
            this.Hide();
            gs.ShowDialog();
            this.Close();
        }

        private void ingredientiText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
