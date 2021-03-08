using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPesoIdeal
{
    public partial class Form1 : Form
    {
        double pesoAtual, altura, pesoIdeal;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(maskedTxtPesoAtual.Text, out pesoAtual) || (!double.TryParse(MaskedTxtAltura.Text, out altura)))
            {
                MessageBox.Show("Valores Inválidos");
            }
            else
            {
                if (rbtnFem.Checked)
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                    if (pesoIdeal == pesoAtual)
                    {
                        MessageBox.Show("Você tem o peso Ideal");
                    }
                    else if (pesoAtual > pesoIdeal)
                    {
                        MessageBox.Show("Você está acima de seu peso ideal");
                    }
                    else
                    {
                        MessageBox.Show("Você está abaixo de seu peso ideal");
                    }
                }
                else
                {
                    pesoIdeal = (72.7 * altura) - 58;
                    if (pesoIdeal == pesoAtual)
                    {
                        MessageBox.Show("Você tem o peso Ideal");
                    }
                    else if (pesoAtual > pesoIdeal)
                    {
                        MessageBox.Show("Você está acima de seu peso ideal");
                    }
                    else
                    {
                        MessageBox.Show("Você está abaixo de seu peso ideal");
                    }
                }

            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtnMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            maskedTxtPesoAtual.Clear();
            MaskedTxtAltura.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void lblPesoAtual_Click(object sender, EventArgs e)
        {

        }
    }
}
