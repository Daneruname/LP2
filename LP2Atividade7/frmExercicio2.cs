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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarH_Click(object sender, EventArgs e)
        {
            int numN = 0;
            double i = 0;

            if (int.TryParse(txtNumN.Text, out numN))
            {
                for (int x = 1; x <= numN; x++)
                {
                    i += 1 / (double)x;
                }

                txtNumH.Clear();

                txtNumH.Text = i.ToString("N2");
            }
            else
            {
                MessageBox.Show("Apenas números permitidos!", "ATENÇÃO!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
