using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            double salarioBruto = 0;

            if ((txtNomeFunc.Text == " ") || (txtNomeFunc.Text.Length < 5))
                MessageBox.Show("Nome Inválido");
            else if (!double.TryParse(mskbxSalBruto.Text, out salarioBruto))
                MessageBox.Show("Salário Inválido");
            else
            {
                double descontoINSS = 0;
                double descontoIR = 0;
                double salarioFamilia = 0;
                double salarioLiquido = 0;
                int filhos = Convert.ToInt32(cbxNumFilhos.SelectedItem);

                //Até 800.47 - 7.65%
                //De 800.48 a 1050 - 8.65%
                //De 1050.01 a 1400.77 – 9.00%
                //De 1400.78 a 2801.56 – 11.00%
                //>2801.56 -> Desconto = 308.17 (teto)

                if (salarioBruto <= 800.47)
                {
                    txtAliquotaINSS.Text = "7.65%";
                    descontoINSS = 7.65 / 100 * salarioBruto;
                }
                else if (salarioBruto <= 1050)
                {
                    txtAliquotaINSS.Text = "8.65%";
                    descontoINSS = 8.65 / 100 * salarioBruto;
                }
                else if (salarioBruto <= 1400.77)
                {
                    txtAliquotaINSS.Text = "9.00%";
                    descontoINSS = 9.00 / 100 * salarioBruto;
                }
                else if (salarioBruto <= 2801.56)
                {
                    txtAliquotaINSS.Text = "11.00%";
                    descontoINSS = 11.00 / 100 * salarioBruto;
                }
                else if (salarioBruto > 2801.56)
                {
                    txtAliquotaINSS.Text = "308.17";
                    descontoINSS = 308.17;
                }

                txtDescontoINSS.Text = descontoINSS.ToString("N2");

                //Alíquota IRPF para Salário Bruto: 
                //Até 1257.12 - isento
                //De 1257.13 a 2512.08 – 15.00 %
                //> 2512.08 - 27.5 %

                if (salarioBruto == 1257.12 || salarioBruto < 1257.12)
                {
                    txtAliquotaIR.Text = "Isento";
                    descontoIR = 0;
                }
                else if (salarioBruto >= 1257.18  || salarioBruto < 2512.08 )
                {
                    txtAliquotaIR.Text = "15%";
                    descontoIR = 0.15 * salarioBruto;
                }
                else if (salarioBruto > 2512.08)
                {
                    txtAliquotaIR.Text = "27.5%";
                    descontoIR = 0.275 * salarioBruto;
                }

                txtDescontoIR.Text = descontoIR.ToString("N2");

                //Salário Família para Salário Bruto: 
                //Até 435.52 - 22.33 por filho
                //De 435.53 a 654.61 - 15.74 por filho
                //> 654.61 – 0

                if (salarioBruto <= 435.52)
                {
                    txtSalFamilia.Text = "22.33 por filho";
                    salarioFamilia = Convert.ToDouble(cbxNumFilhos.SelectedItem) * 22.33;
                }

                else if (salarioBruto <= 654.61)
                {
                    txtSalFamilia.Text = "15.74 por filho";
                    salarioFamilia = Convert.ToDouble(cbxNumFilhos.SelectedItem) * 15.74;
                }

                else if (salarioBruto > 654.61)
                {
                    txtSalFamilia.Text = "0";
                    salarioFamilia = 0;
                }

                txtSalFamilia.Text = salarioFamilia.ToString("N2");

                salarioLiquido = salarioBruto - descontoINSS - descontoIR + salarioFamilia;
                txtSalLiquido.Text = salarioLiquido.ToString("N2");

                // preencher label 

                string texto = "Os descontos do Salário";

                if (rbtnFem.Checked)
                    texto = texto + " da Sra." ;
                else
                    texto = texto + " do Sr." ;

                if (ckbxCasado.Checked)
                    texto = texto + " que é casado(a)";
                else
                    texto = texto + " que é solteiro(a)";

                texto = texto + " e que tem " + cbxNumFilhos.SelectedItem.ToString() + " Filho(s).";

                lblMensagem.Text = texto;
               

            }

          


        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFunc.Clear();
            mskbxSalBruto.Clear();
        }
    }
}
