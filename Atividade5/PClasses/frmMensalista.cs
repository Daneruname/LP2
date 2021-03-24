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
    public partial class frmMensalista : Form
    {
        public frmMensalista() //construtor do mensalistaa
        {
            InitializeComponent();
        }

              
      
       
        private void btnInstMensal_Click(object sender, EventArgs e)
        {
            //criar ou instanciar o objeto da classe mensalista

            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrEmpr.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);

            //get
            MessageBox.Show("Matrícula    : " + objMensalista.Matricula + "\n" +
                            "Nome         : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada : " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salário Bruto: " + objMensalista.SalarioBruto() + "\n" +
                            "Tempo Empresa (dias): " + objMensalista.TempoTrabalho());

        }

        private void btnInst2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text),
                txtNome.Text, Convert.ToDateTime(txtDataEntrEmpr.Text),
                Convert.ToDouble(txtSalarioMensal.Text));


            MessageBox.Show( "Matrícula    : " + objMensalista.Matricula + "\n" +
                            "Nome         : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada : " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salário Bruto: " + objMensalista.SalarioBruto() + "\n" +
                            "Tempo Empresa (dias): " + objMensalista.TempoTrabalho());

        }
    }
}
