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
    }
}
