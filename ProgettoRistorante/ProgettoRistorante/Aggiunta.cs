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
            
            if (!(String.IsNullOrEmpty(nomeText.Text)) && !(String.IsNullOrEmpty(prezzoText.Text))&& !(String.IsNullOrEmpty(ingredientiText.Text))&& !(String.IsNullOrEmpty(ingredientiText.Text)))
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
                scriviAppend(@"Menu.csv", nomeText.Text);
                try
                {
                    int.Parse(prezzoText.Text);
                }
                catch (Exception ecc)
                {
                    MessageBox.Show("Prezzo invalido");
                    
                }
                scriviAppend(@"Menu.csv", prezzoText.Text);
                string[] tmp = ingredientiText.Text.Split('\n');
                
                string ingredienti="";
                for (int i=0; i < tmp.Length; i++)
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
                scriviAppend(@"Menu.csv", ingredienti);
                scriviAppend(@"Menu.csv", portataBox.Text);
                scriviAppend(@"Menu.csv", ";");
                nomeText.Text = string.Empty;
                prezzoText.Text = string.Empty;
                ingredientiText.Text = string.Empty;
                portataBox.Text = portataBox.Items[0].ToString();
            } else
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
    }
}
