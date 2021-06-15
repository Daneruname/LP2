using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030482011006
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=LAPTOP-J1H8CMUC\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True;Pooling=False");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros tipos de erro" + ex.Message);
            }
            
        }

        private void cadastroDeVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVacina FRMVacina = new frmVacina();
            FRMVacina.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre FRMSobre = new frmSobre();
            FRMSobre.Show();
        }
    }
}
