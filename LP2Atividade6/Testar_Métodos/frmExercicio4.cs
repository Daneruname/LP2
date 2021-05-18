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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContarNumeros_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var i = 0; i<rchtxtTexto.Text.Length; i++)
            {
                if (char.IsNumber(rchtxtTexto.Text[i]))
                    contador += 1;
            }
            MessageBox.Show("Quantidade de números: " + contador);
        }

        private void btnPosicao_Click(object sender, EventArgs e)
        {
            int i = 0;
            int posicao = i-1;
            string v = rchtxtTexto.Text;
            if (v == "")
            {
                MessageBox.Show("Todo o conteúdo está em branco.");
            }
            else
            {
                while (posicao < 0)
                {
                    if (!char.IsWhiteSpace(rchtxtTexto.Text[i]))
                    {
                        i += 1;
                    }
                    else
                    {
                        posicao = i;
                    }
                }
                MessageBox.Show("Posição do primeiro espaço em branco: " + posicao);
            }            
        }

        private void btnContarLetras_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (char letra in rchtxtTexto.Text)
            {
                if (char.IsLetter(letra))
                    contador += 1;
            }                                
            MessageBox.Show("Quantidade de letras: " + contador);
        }
    }
}
