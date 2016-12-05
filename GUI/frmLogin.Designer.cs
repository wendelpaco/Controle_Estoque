namespace GUI
{
    partial class frmLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtSair = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtEntrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Erro = new MaterialSkin.Controls.MaterialLabel();
            this.Status = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtSair);
            this.groupBox1.Controls.Add(this.BtEntrar);
            this.groupBox1.Controls.Add(this.Erro);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.TxtSenha);
            this.groupBox1.Controls.Add(this.TxtUsuario);
            this.groupBox1.Location = new System.Drawing.Point(4, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 319);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // BtSair
            // 
            this.BtSair.Depth = 0;
            this.BtSair.Location = new System.Drawing.Point(175, 158);
            this.BtSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtSair.Name = "BtSair";
            this.BtSair.Primary = true;
            this.BtSair.Size = new System.Drawing.Size(113, 33);
            this.BtSair.TabIndex = 22;
            this.BtSair.Text = "  Sair  ";
            this.BtSair.UseVisualStyleBackColor = true;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // BtEntrar
            // 
            this.BtEntrar.Depth = 0;
            this.BtEntrar.Location = new System.Drawing.Point(18, 158);
            this.BtEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Primary = true;
            this.BtEntrar.Size = new System.Drawing.Size(113, 33);
            this.BtEntrar.TabIndex = 4;
            this.BtEntrar.Text = "  Entrar  ";
            this.BtEntrar.UseVisualStyleBackColor = true;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
            // 
            // Erro
            // 
            this.Erro.AutoSize = true;
            this.Erro.Depth = 0;
            this.Erro.Font = new System.Drawing.Font("Roboto", 11F);
            this.Erro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Erro.Location = new System.Drawing.Point(48, 244);
            this.Erro.MouseState = MaterialSkin.MouseState.HOVER;
            this.Erro.Name = "Erro";
            this.Erro.Size = new System.Drawing.Size(206, 19);
            this.Erro.TabIndex = 21;
            this.Erro.Text = "Usuário e/ou Senha incorreto";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Depth = 0;
            this.Status.Font = new System.Drawing.Font("Roboto", 11F);
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status.Location = new System.Drawing.Point(49, 245);
            this.Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(222, 19);
            this.Status.TabIndex = 20;
            this.Status.Text = "Preencha o campos para entrar!";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(204, 299);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Versão: beta";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Depth = 0;
            this.TxtSenha.Hint = "Password";
            this.TxtSenha.Location = new System.Drawing.Point(13, 106);
            this.TxtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.SelectedText = "";
            this.TxtSenha.SelectionLength = 0;
            this.TxtSenha.SelectionStart = 0;
            this.TxtSenha.Size = new System.Drawing.Size(275, 23);
            this.TxtSenha.TabIndex = 2;
            this.TxtSenha.UseSystemPasswordChar = false;
            this.TxtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Hint = "Usuário";
            this.TxtUsuario.Location = new System.Drawing.Point(13, 51);
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.Size = new System.Drawing.Size(275, 23);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.UseSystemPasswordChar = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 390);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel Status;
        private MaterialSkin.Controls.MaterialLabel Erro;
        private MaterialSkin.Controls.MaterialRaisedButton BtEntrar;
        private MaterialSkin.Controls.MaterialRaisedButton BtSair;
    }
}