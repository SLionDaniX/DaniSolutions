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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void lblCadastroProdutos_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeProdutos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nome = "Teclados";
            
            if (txtNomeProdutos.Text == nome)
            {
                MessageBox.Show("Esse produto "+nome+"já foi cadastrado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("Esse produto está apto a ser cadastrado!!");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String nome = "Teclados";

            if (txtNomeProdutos.Text == nome)
            {
                MessageBox.Show("Esse produto já foi cadastrado","aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Produto cadastrado com sucesso!!!");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produto excluído do estoque com sucesso!!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produto alterado com sucesso!!");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNomeProdutos.Focus();
            txtNomeProdutos.Clear();
            txtCodigoBarras.Clear();
            mtbDataRetirada.Clear();
        }
    }
}
