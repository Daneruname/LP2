using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade7
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int prod, salario, gratificacao;
            bool resultado;
            
            resultado = int.TryParse(txtProducao.Text, out prod);

            if (!resultado) MessageBox.Show("Apenas números permitidos em Produção");

            resultado = int.TryParse(txtSalario.Text, out salario);

            if (!resultado) MessageBox.Show("Apenas números permitidos em Salário");

            resultado = int.TryParse(txtGratificacao.Text, out gratificacao);

            if (!resultado) MessageBox.Show("Apenas números permitidos em Gratificação");

            double salbruto;

            if (prod >= 150)
                salbruto = salario + salario * 0.25 + gratificacao;
            else if (prod >= 120)
                salbruto = salario + salario * 0.15 + gratificacao;
            else if (prod >= 100)
                salbruto = salario + salario * 0.05 + gratificacao;
            else
                salbruto = salario + gratificacao;

            if (salbruto > 7000)
            {
                if (prod >= 150 && gratificacao >= 1)
                    txtSalBruto.Text = salbruto.ToString("N2");
                else
                    txtSalBruto.Text = (7000.00).ToString("N2");
            }
            else
                txtSalBruto.Text = salbruto.ToString("N2");

        }
    }
}
