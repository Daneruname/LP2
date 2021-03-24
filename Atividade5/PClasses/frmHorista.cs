using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista() ;

            //set
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHora.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrEmpresa.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);

            //get

            MessageBox.Show("Nome:" + objHorista.NomeEmpregado +
                "\n" + "Matrícula:" + objHorista.Matricula + "\n" +
                "Tempo Trabalho:" + objHorista.TempoTrabalho().ToString() + "\n" +
                "Salário:" + objHorista.SalarioBruto().ToString("N2"));


        }
    }
}
