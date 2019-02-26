namespace Cliente
{
    partial class frmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblCadastroProdutos = new System.Windows.Forms.Label();
            this.txtNomeProdutos = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblNomeProdutos = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblDataRetirada = new System.Windows.Forms.Label();
            this.mtbDataRetirada = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Azure;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBuscar.Location = new System.Drawing.Point(310, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 52);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Azure;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAlterar.Location = new System.Drawing.Point(422, 164);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(106, 52);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Azure;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnApagar.Location = new System.Drawing.Point(310, 164);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(106, 52);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Azure;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCadastrar.Location = new System.Drawing.Point(422, 106);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 52);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Azure;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(200, 302);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 61);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Azure;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNovo.Location = new System.Drawing.Point(363, 222);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 52);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblCadastroProdutos
            // 
            this.lblCadastroProdutos.AutoSize = true;
            this.lblCadastroProdutos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProdutos.Location = new System.Drawing.Point(182, 33);
            this.lblCadastroProdutos.Name = "lblCadastroProdutos";
            this.lblCadastroProdutos.Size = new System.Drawing.Size(225, 30);
            this.lblCadastroProdutos.TabIndex = 10;
            this.lblCadastroProdutos.Text = "Cadastro de produtos";
            this.lblCadastroProdutos.Click += new System.EventHandler(this.lblCadastroProdutos_Click);
            // 
            // txtNomeProdutos
            // 
            this.txtNomeProdutos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProdutos.Location = new System.Drawing.Point(36, 117);
            this.txtNomeProdutos.MaxLength = 50;
            this.txtNomeProdutos.Name = "txtNomeProdutos";
            this.txtNomeProdutos.Size = new System.Drawing.Size(162, 25);
            this.txtNomeProdutos.TabIndex = 0;
            this.txtNomeProdutos.TextChanged += new System.EventHandler(this.txtNomeProdutos_TextChanged);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(36, 174);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(162, 25);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // lblNomeProdutos
            // 
            this.lblNomeProdutos.AutoSize = true;
            this.lblNomeProdutos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutos.Location = new System.Drawing.Point(36, 98);
            this.lblNomeProdutos.Name = "lblNomeProdutos";
            this.lblNomeProdutos.Size = new System.Drawing.Size(131, 17);
            this.lblNomeProdutos.TabIndex = 14;
            this.lblNomeProdutos.Text = "Nome dos produtos:";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarras.Location = new System.Drawing.Point(33, 154);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(126, 17);
            this.lblCodigoBarras.TabIndex = 4;
            this.lblCodigoBarras.Text = "Código do produto:";
            // 
            // lblDataRetirada
            // 
            this.lblDataRetirada.AutoSize = true;
            this.lblDataRetirada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRetirada.Location = new System.Drawing.Point(33, 202);
            this.lblDataRetirada.Name = "lblDataRetirada";
            this.lblDataRetirada.Size = new System.Drawing.Size(107, 17);
            this.lblDataRetirada.TabIndex = 16;
            this.lblDataRetirada.Text = "Data de retirada:";
            // 
            // mtbDataRetirada
            // 
            this.mtbDataRetirada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataRetirada.Location = new System.Drawing.Point(36, 222);
            this.mtbDataRetirada.Mask = "00/00/0000";
            this.mtbDataRetirada.Name = "mtbDataRetirada";
            this.mtbDataRetirada.Size = new System.Drawing.Size(86, 25);
            this.mtbDataRetirada.TabIndex = 2;
            this.mtbDataRetirada.ValidatingType = typeof(System.DateTime);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(552, 375);
            this.Controls.Add(this.mtbDataRetirada);
            this.Controls.Add(this.lblDataRetirada);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.lblNomeProdutos);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.txtNomeProdutos);
            this.Controls.Add(this.lblCadastroProdutos);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblCadastroProdutos;
        private System.Windows.Forms.TextBox txtNomeProdutos;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblNomeProdutos;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label lblDataRetirada;
        private System.Windows.Forms.MaskedTextBox mtbDataRetirada;
    }
}