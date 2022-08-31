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
    public partial class Recupera : Form
    {
        public Recupera()
        {
            InitializeComponent();
        }

        private void Recupera_Load(object sender, EventArgs e)
        {
            RecuperaEliminati();
        }
        public  void RecuperaEliminati()
        {
            string piattiEliminati = leggiEliminati(@"Menu.csv");
            string[] piatti = piattiEliminati.Split('\n');
            string[] nomiPiatti = new string[50];
            int cont = 0;
            for (int i = 0; i < piatti.Length; i++)
            {
                if (piatti[i] == "Nome:")
                {
                    nomiPiatti[cont] = piatti[i + 1];
                    cont++;
                }
            }
            for (int i = 0; i < nomiPiatti.Length; i++)
            {
                if (nomiPiatti[i] != null)
                {
                    piattiBox.Items.Add(nomiPiatti[i]);
                }
                else break;
            }
        }
        public static string leggiEliminati(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            string piattiEliminati = "";
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "//")
                {
                    line = sr.ReadLine();
                    while (line != "//")
                    {
                        piattiEliminati += line+"\n";
                        line = sr.ReadLine();
                    }
                }
            }
            sr.Close();
            return piattiEliminati; 
        }
        public static string Leggi(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            string piatti = "";
            while ((line = sr.ReadLine()) != null)
            {
                piatti += line + "\n";
            }
            sr.Close();
            return piatti.Trim();
        }
        public static void scriviAppend(string filename, string content)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }

        private void confermaButton_Click(object sender, EventArgs e)
        {
            if (piattiBox.Text != string.Empty)
            {
                string piattiEliminati = leggiEliminati(@"Menu.csv");
                string file = Leggi(@"Menu.csv");
                bool isOver = false;
                string[] fileSplit = file.Split('\n');
                for(int i=0; i < fileSplit.Length; i++)
                {
                    if (fileSplit[i] == "//")
                    {
                        isOver = true;
                        if (fileSplit[i + 2] == piattiBox.Text)
                        {
                            fileSplit[i] = string.Empty;
                            i++;
                            while (fileSplit[i] != "//")
                            {
                                i++;
                            }
                            fileSplit[i] = string.Empty;
                            break;
                        }
                    }
                }
                string tmp = "";
                for(int i = 0; i < fileSplit.Length; i++)
                {
                    tmp += fileSplit[i] + "\n";
                }
                File.Delete(@"Menu.csv");
                scriviAppend(@"Menu.csv",tmp);
                piattiBox.Text = string.Empty;
                RecuperaEliminati();
            }
        }
    }
}
