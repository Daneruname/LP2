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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            string texto = rchtxtTexto.Text;
            int white = 0;
            
            foreach (char x in texto)
            {
                if (Char.IsWhiteSpace(x))
                {
                    white++;
                }
            }

            MessageBox.Show("Tem " + white + " espaços em branco");

        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            string texto = rchtxtTexto.Text.ToLower();
            int letraR = 0;

            foreach (char x in texto)
            {
                if (x.Equals('r'))
                {
                    letraR++;
                }
            }

            MessageBox.Show("Tem " + letraR + " letras R no texto");

        }

        private void btnLetrasPares_Click(object sender, EventArgs e)
        {
            int pares = 0;
            string texto = rchtxtTexto.Text.ToLower();

            for (int x = 0; x < texto.Length - 1; x++)
            {
                if (texto[x].Equals(texto[x+1]))
                {
                    pares++;
                }
            }

            MessageBox.Show("Tem " + pares + " pares nesse texto");
        }
    }
}
