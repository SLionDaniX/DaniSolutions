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
    public partial class frmUsuário : Form
    {
        public frmUsuário()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Close();
        }


        private void Usuários_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            String nome = "Danilo", vt = "";

            if (txtUsuário.Text == vt)
            {
                MessageBox.Show("Por favor digite um usuário para fazer a busca no banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtUsuário.Text == nome)
            {
                if (nome == txtUsuário.Text)
                {
                    MessageBox.Show("Esse usuário já existe!");
                }
                else
                {
                    MessageBox.Show("Você está apto a cadastrar um usuário");
                }
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtUsuário.Focus();
            txtUsuário.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            String senha = "";

            senha = txtSenha.Text;

            //if (txtUsuário.Text == nome)
            //{
            //    MessageBox.Show("Esse usuário já existe");

            //}

            if (txtConfirmaSenha.Text == senha)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            else
            {
                txtConfirmaSenha.Focus();
                txtConfirmaSenha.Clear();
                MessageBox.Show("As senhas não se coincidem!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alterado com sucesso!!");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtUsuário.Focus();
            txtUsuário.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
            MessageBox.Show("Usuário excluido com sucesso!!");
        }
    }
}
