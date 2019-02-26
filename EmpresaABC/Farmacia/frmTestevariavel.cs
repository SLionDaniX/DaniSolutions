using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmTestevariavel : Form
    {
        public frmTestevariavel()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "Senac Largo Treze";
            lblNCompleto.Text = "Aniely";
        }
    }
}
