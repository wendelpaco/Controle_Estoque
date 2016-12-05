namespace GUI
{
    partial class frmCadastroCategoria2
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
            this.pnDados = new System.Windows.Forms.GroupBox();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnLocalizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnInserir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnDados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCod);
            this.pnDados.Location = new System.Drawing.Point(6, 66);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(598, 328);
            this.pnDados.TabIndex = 0;
            this.pnDados.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome da Categoria";
            this.txtNome.Location = new System.Drawing.Point(6, 81);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(574, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtCod
            // 
            this.txtCod.Depth = 0;
            this.txtCod.Hint = "Código";
            this.txtCod.Location = new System.Drawing.Point(6, 39);
            this.txtCod.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCod.Name = "txtCod";
            this.txtCod.PasswordChar = '\0';
            this.txtCod.SelectedText = "";
            this.txtCod.SelectionLength = 0;
            this.txtCod.SelectionStart = 0;
            this.txtCod.Size = new System.Drawing.Size(75, 23);
            this.txtCod.TabIndex = 1;
            this.txtCod.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnCancelar);
            this.groupBox2.Controls.Add(this.BtnSalvar);
            this.groupBox2.Controls.Add(this.BtnExcluir);
            this.groupBox2.Controls.Add(this.BtnAlterar);
            this.groupBox2.Controls.Add(this.BtnLocalizar);
            this.groupBox2.Controls.Add(this.BtnInserir);
            this.groupBox2.Location = new System.Drawing.Point(6, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.Depth = 0;
            this.BtnCancelar.Location = new System.Drawing.Point(499, 18);
            this.BtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Primary = true;
            this.BtnCancelar.Size = new System.Drawing.Size(93, 58);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalvar.Depth = 0;
            this.BtnSalvar.Location = new System.Drawing.Point(400, 18);
            this.BtnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Primary = true;
            this.BtnSalvar.Size = new System.Drawing.Size(93, 58);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExcluir.Depth = 0;
            this.BtnExcluir.Location = new System.Drawing.Point(301, 18);
            this.BtnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Primary = true;
            this.BtnExcluir.Size = new System.Drawing.Size(93, 58);
            this.BtnExcluir.TabIndex = 6;
            this.BtnExcluir.Text = "Exlcuir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAlterar.Depth = 0;
            this.BtnAlterar.Location = new System.Drawing.Point(202, 18);
            this.BtnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Primary = true;
            this.BtnAlterar.Size = new System.Drawing.Size(93, 58);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnLocalizar
            // 
            this.BtnLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLocalizar.Depth = 0;
            this.BtnLocalizar.Location = new System.Drawing.Point(103, 18);
            this.BtnLocalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLocalizar.Name = "BtnLocalizar";
            this.BtnLocalizar.Primary = true;
            this.BtnLocalizar.Size = new System.Drawing.Size(93, 58);
            this.BtnLocalizar.TabIndex = 4;
            this.BtnLocalizar.Text = "Localizar";
            this.BtnLocalizar.UseVisualStyleBackColor = true;
            this.BtnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnInserir.Depth = 0;
            this.BtnInserir.Location = new System.Drawing.Point(4, 18);
            this.BtnInserir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Primary = true;
            this.BtnInserir.Size = new System.Drawing.Size(93, 58);
            this.BtnInserir.TabIndex = 3;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // frmCadastroCategoria2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnDados);
            this.Name = "frmCadastroCategoria2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Sub Categoria";
            this.pnDados.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.GroupBox pnDados;
        protected System.Windows.Forms.GroupBox groupBox2;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtCod;
        protected MaterialSkin.Controls.MaterialRaisedButton BtnCancelar;
        protected MaterialSkin.Controls.MaterialRaisedButton BtnSalvar;
        protected MaterialSkin.Controls.MaterialRaisedButton BtnExcluir;
        protected MaterialSkin.Controls.MaterialRaisedButton BtnAlterar;
        protected MaterialSkin.Controls.MaterialRaisedButton BtnLocalizar;
        protected MaterialSkin.Controls.MaterialRaisedButton BtnInserir;
    }
}