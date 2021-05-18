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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string texto = txtPali.Text.ToUpper().Replace(" ", "");
            char[] inverso = texto.ToCharArray();

            Array.Reverse(inverso);

            string otxet = new String(inverso);

            if (otxet.Equals(texto)) MessageBox.Show("É um palíndromo! \n\n" + otxet);
            else MessageBox.Show("Não é um palíndromo! \n\n" + otxet);
        }
    }
}
