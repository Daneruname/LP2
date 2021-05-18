using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testar_Métodos
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnTestaIguais_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true)==0)
                MessageBox.Show("São iguais");
            else
                MessageBox.Show("São diferentes");
        }

        private void btnInserirPrimeiroNoSegundo_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra2.Text.Length / 2;
            //txtPalavra1.Text=a

            //txtPalavra2.Text
            //casa ---> meio = 2
            //fatec --> meio = 2
            //sorocaba --> meio=4
            //tecnologias --> meio = 5

            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) +
                txtPalavra1.Text + txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length-meio);
        }

        private void btnInserirDoisAsteriscos_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(meio, "**");
        }
    }
}
