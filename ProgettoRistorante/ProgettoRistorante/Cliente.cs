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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void aggiungiButton_Click(object sender, EventArgs e)
        {
            Ordina ord = new Ordina();
            this.Hide();
            ord.ShowDialog();
            this.Close();
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            EliminaCliente ord = new EliminaCliente();
            this.Hide();
            ord.ShowDialog();
            this.Close();
        }

        private void scontrinoButton_Click(object sender, EventArgs e)
        {
            Scontrino ord = new Scontrino();
            this.Hide();
            ord.ShowDialog();
            this.Close();
        }
    }
}
