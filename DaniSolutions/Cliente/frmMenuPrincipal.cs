using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionários abrir = new Funcionários();
            abrir.Show();
            this.Hide();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuário abrir = new frmUsuário();
            abrir.Show();
            this.Close();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos abrir = new frmProdutos();
            abrir.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            frmFornecedores abrir = new frmFornecedores();
            abrir.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Close();
        }
    }
}
