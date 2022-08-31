using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoRistorante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Piatto
        {
            public string nome;
            public string prezzo;
            public string[] ingredienti;
            public string portata;
        }
        private void accessoCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            this.Hide();
            cliente.ShowDialog();
            this.Close();
        }

        private void accessoGestore_Click(object sender, EventArgs e)
        {
            AccessoGestore gestore = new AccessoGestore();
            this.Hide();
            gestore.ShowDialog();
            this.Close();
        }
    }
}
