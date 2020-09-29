using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        double numero1, numero2;
        double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtnum2.Clear();
            txtnum3.Text = String.Empty;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            
            if ((double.TryParse(txtNum1.Text, out numero1)) &&
                    (double.TryParse(txtnum2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtnum3.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            
            if ((double.TryParse(txtNum1.Text, out numero1)) &&
                    (double.TryParse(txtnum2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtnum3.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Números inválidos!");

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            
            if ((double.TryParse(txtNum1.Text, out numero1)) &&
                    (double.TryParse(txtnum2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtnum3.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
           
            if ((double.TryParse(txtNum1.Text, out numero1)) &&
                    (double.TryParse(txtnum2.Text, out numero2)))
            {
                if (numero2 == 0)
                    MessageBox.Show("Denominador não pode ser zero");
                else
                {
                    resultado = numero1 / numero2;
                    txtnum3.Text = resultado.ToString("N2");
                }
            }
            else
                MessageBox.Show("Números inválidos!");
        }
    }
}
