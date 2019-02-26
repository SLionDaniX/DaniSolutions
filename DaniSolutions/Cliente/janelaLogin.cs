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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        
        public void login()
        {
            string name = "Adm", Password = "123456";
            name = txtUser.Text;
            Password = txtPasswd.Text;

            if ((name == "Adm") && (Password == "123456"))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Please enter correct username and password ");
                txtUser.Focus();
                txtUser.Clear();
                txtPasswd.Clear();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtPasswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
