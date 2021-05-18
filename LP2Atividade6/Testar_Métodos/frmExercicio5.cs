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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumero1.Text);
            int num2 = Convert.ToInt32(txtNumero2.Text);
            if (num1 > num2)
            {
                MessageBox.Show("O primeiro número é maior que o segundo.\n" +
                    "Insira os números na ordem correta.", "Erro!!");
            }
            else
            {
                Random random = new Random();
                double r = random.Next(num1, num2);
                MessageBox.Show(r.ToString());
            }
        }
    }
}
