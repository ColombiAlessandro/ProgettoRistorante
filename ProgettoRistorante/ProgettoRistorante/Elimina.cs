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
    public partial class Elimina : Form
    {
        public Elimina()
        {
            InitializeComponent();
        }

        private void Elimina_Load(object sender, EventArgs e)
        {

        }

        private void confermaButton_Click(object sender, EventArgs e)
        {
            string file = leggi(@"Menu.csv");
            string fileEl = EliminaLog(file, nomeText.Text);
            File.Delete(@"Menu.csv");
            scriviAppend(@"Menu.csv",fileEl);
        }
        static string EliminaLog(string file, string nome)
        {
            string[] filesplit = SplitString("Nome:", ";", file);
            for(int i=0; i < filesplit.Length; i++)
            {
                if (filesplit[i] != null)
                {
                    string[] tmp = filesplit[i].Split('\n');
                    if (tmp[1] == nome)
                    {
                        filesplit[i] = $"//\n{filesplit[i]}\n//";
                        break;
                    }
                }
                else break;
            }
            string fileEl = "";
            for(int i = 0; i < filesplit.Length; i++)
            {
                if (filesplit[i] != null)
                {
                    fileEl += filesplit[i] + "\n";
                }
                else break;
            }
            return fileEl;
        }
        static string[] SplitString(string splitStart, string splitEnd, string stringa)
        {
            string[] file = stringa.Split('\n');
            string[] newFile = new string[file.Length];
            
            int cont = 0;
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i] == "//")
                {
                    newFile[cont] += "//\n";
                    i++;
                    while (file[i] != "//")
                    {
                        newFile[cont] += file[i] + "\n";
                        i++;
                    }
                    newFile[cont] += "//\n";
                    cont++;
                } else if (file[i] == splitStart)
                {
                    while (file[i] != splitEnd)
                    {
                        newFile[cont] += file[i] + "\n";
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
        public static string leggi(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            string file = "";
            while ((line = sr.ReadLine()) != null)
            {
                file += line + "\n";
            }
            sr.Close();
            return file;
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            ricompattaButton.Visible = false;
            label1.Visible = true;
            nomeText.Visible = true;
            confermaButton.Visible = true;
            eliminaButton.Visible = false;
        }

        private void ricompattaButton_Click(object sender, EventArgs e)
        {
            string file = leggi(@"Menu.csv");
            string [] fileSplit = file.Split('\n');
            file = "";
            for(int i=0; i < fileSplit.Length; i++)
            {
                if (fileSplit[i] == "//")
                {
                    i++;
                    while (fileSplit[i] != "//")
                    {
                        i++;
                    }
                    i++;
                }
                file += fileSplit[i]+"\n";
            }
            File.Delete(@"Menu.csv");
            scriviAppend(@"Menu.csv", file);
            MessageBox.Show("File ricompattato");
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
