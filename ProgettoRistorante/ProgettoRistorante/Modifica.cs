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
    public partial class Modifica : Form
    {
        public Modifica()
        {
            InitializeComponent();
        }
        public static string leggi(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            string file="";
            while ((line = sr.ReadLine()) != null)
            {
                file += line + "\n";
            }
            sr.Close();
            return file;
        }
        private void confermaBottone_Click(object sender, EventArgs e)
        {
            

            if (!(String.IsNullOrEmpty(nuovoNomeText.Text)) && !(String.IsNullOrEmpty(nuovoPrezzoText.Text)) && !(String.IsNullOrEmpty(ingredientiTextBox.Text)) && !(String.IsNullOrEmpty(portataBox.Text)))
            {

                try
                {
                    int.Parse(nuovoPrezzoText.Text);
                }
                catch (Exception ecc)
                {
                    MessageBox.Show("Prezzo invalido");
                    nuovoNomeText.Text = string.Empty;
                    nomeText.Text = string.Empty;
                    nuovoPrezzoText.Text = string.Empty;
                    ingredientiTextBox.Text = string.Empty;
                    return;
                }
              
                string[] tmp = ingredientiTextBox.Text.Split('\n');

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
                string file = leggi(@"Menu.csv");
                bool isFound = false;
                string fileMod = ModificaFile(nomeText.Text, file,nuovoPrezzoText.Text,nuovoNomeText.Text,ingredienti,portataBox.Text, ref isFound);
                if (isFound)
                {
                    File.Delete(@"Menu.csv");
                    scriviAppend(@"Menu.csv", fileMod);
                } else
                {
                    MessageBox.Show("Piatto non trovato");
                }
                nomeText.Text = string.Empty;
                nuovoPrezzoText.Text = string.Empty;
                nuovoNomeText.Text = string.Empty;
                ingredientiTextBox.Text = string.Empty;
                portataBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Uno o più valori non validi");
            }
            

        }
        static string ModificaFile(string nome, string file, string prezzo, string nuovoNome,string ingredienti, string portata, ref bool isFound)
        {

            string[] controllo = SplitString("Nome:", ";", file);
            
            for(int i=0; i < controllo.Length; i++)
            {
                if (controllo[i] != null)
                {
                    string[] tmp = controllo[i].Split('\n');
                    if (tmp[1] == nome)
                    {
                        string nuovo = $"Nome:\n{nuovoNome}\nPrezzo:\n{prezzo}\nIngredienti:\n+{ingredienti}\nPortata:\n{portata}\n;\n";
                        controllo[i] = nuovo;
                        isFound = true;
                    }
                    
                }
                else break;
            }
            string fileMod = "";
            for (int i = 0; i < controllo.Length; i++)
            {
                if (controllo[i] != null)
                {
                    fileMod += $"{controllo[i]}\n";
                }
            }
            return fileMod;
            
        }
        static string[] SplitString(string splitStart, string splitEnd, string stringa)
        {
            string[] file = stringa.Split('\n');
            string[] newFile = new string[file.Length];
            int cont = 0;
            for(int i=0; i < file.Length; i++)
            {
                if (file[i] == "//")
                {
                    i++;
                    while (file[i] != "//")
                    {
                        i++;
                    }
                    i++;
                }
                if (file[i] == splitStart)
                {
                    while (file[i] != splitEnd)
                    {
                        newFile[cont] += file[i]+"\n";
                        i++;
                    }
                    newFile[cont] += $"{splitEnd}\n";
                    newFile[cont] = newFile[cont].Trim();
                    cont++;
                    
                }
            }
            return newFile;
        }
        public static void scriviAppend(string filename, string content)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }

        private void ingredientiTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
