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
    public partial class EliminaCliente : Form
    {
        Form1.Piatto[] piatti = new Form1.Piatto[100];
        int cont = 0;
        public EliminaCliente()
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

        private void EliminaCliente_Load(object sender, EventArgs e)
        {
            string[] nomiPiatti = leggi(@"Ordine.csv", ref cont);
            for(int i=0; i < cont; i++)
            {
                nomiBox.Items.Add(nomiPiatti[i]);
            }
        }
        public static string[] leggi(string filename, ref int cont)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            cont = 0;
            string[] nomiPiatti = new string[100];
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "Nome:")
                {
                    nomiPiatti[cont] = sr.ReadLine();
                    cont++;
                }
            }
            sr.Close();
            return nomiPiatti;
        }
        public static string leggiElimina(string filename, string elimina)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            string fileElimina="";
            bool isFound = false;
            while ((line = sr.ReadLine()) != null)
            {
                isFound = false;
                if (line == "Nome:")
                {
                    line = sr.ReadLine();
                    if (line == elimina){
                        while (line != ";")
                        {
                            line=sr.ReadLine();
                        }
                        isFound = true;
                        elimina = "";
                    }
                    if (!isFound)
                    {
                        fileElimina += "Nome:\n" + line + "\n";
                    }
                } else
                {
                    fileElimina += line +"\n";
                }
            }
            sr.Close();
            return fileElimina;
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
            if (nomiBox.Text != string.Empty)
            {   
                string file = leggiElimina(@"Ordine.csv", nomiBox.Text);
                File.Delete(@"Ordine.csv");
                scriviAppend(@"Ordine.csv", file);
                nomiBox.Items.Clear();
                string[] nomiPiatti = leggi(@"Ordine.csv", ref cont);
                for (int i = 0; i < cont; i++)
                {
                    nomiBox.Items.Add(nomiPiatti[i]);
                }   
            }
        }
    }
}
