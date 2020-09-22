using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraLP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAlt.Clear();
            txtRaio.Text = " ";
            txtVol.Text = String.Empty;

            txtRaio.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alt, raio;

            if (double.TryParse(txtAlt.Text, out alt)
                && (double.TryParse(txtRaio.Text, out raio)))
            {
                double vol;
                vol = Math.PI * Math.Pow(raio, 2) * alt;

                txtVol.Text = vol.ToString("N2");
            }
            else
                MessageBox.Show("Estes valores são inválidos. Tente novamente.");

        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }

        }
    } 
}
