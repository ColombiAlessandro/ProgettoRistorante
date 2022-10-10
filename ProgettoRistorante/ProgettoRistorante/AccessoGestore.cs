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
    public partial class AccessoGestore : Form
    {
        public AccessoGestore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                string password = leggiPassword(@"Password.csv");
                if (password == textBox1.Text)
                {
                    Gestore ges = new Gestore();
                    this.Hide();
                    ges.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password errata");
                    textBox1.Text = string.Empty;
                }
        }
        public static string leggiPassword(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            string password="";
            while ((line = sr.ReadLine()) != null)
            {
                password = line;
            }
            sr.Close();
            return password;
        }

        private void AccessoGestore_Load(object sender, EventArgs e)
        {
            if (leggiPassword(@"Password.csv") == "")
            {
                avantiButton.Visible = false;
                avantiButtonPassword.Visible = true;
                label1.Text = "Inserisci una nuova password";
            }
        }

        private void avantiButtonPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                StreamWriter sr = new StreamWriter(@"Password.csv");
                sr.WriteLine(textBox1.Text);
                MessageBox.Show("Nuova password impostata");
                AccessoGestore ges = new AccessoGestore();
                sr.Close();
                this.Hide();
                ges.ShowDialog();
                this.Close();
                File.Delete(@"Menu.csv");
                File.Create(@"Menu.csv");
            }
            else MessageBox.Show("Password non valida");
        }
            
    }
}
