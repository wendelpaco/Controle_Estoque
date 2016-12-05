namespace GUI
{
    partial class frmCadastroSubCategoria2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbCatCod = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pnDados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.materialLabel1);
            this.pnDados.Controls.Add(this.btAdd);
            this.pnDados.Controls.Add(this.cbCatCod);
            this.pnDados.Controls.SetChildIndex(this.txtCod, 0);
            this.pnDados.Controls.SetChildIndex(this.txtNome, 0);
            this.pnDados.Controls.SetChildIndex(this.cbCatCod, 0);
            this.pnDados.Controls.SetChildIndex(this.btAdd, 0);
            this.pnDados.Controls.SetChildIndex(this.materialLabel1, 0);
            // 
            // txtNome
            // 
            this.txtNome.Hint = "Nome da Sub Categoria";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnLocalizar
            // 
            this.BtnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btAdd
            // 
            this.btAdd.Depth = 0;
            this.btAdd.Location = new System.Drawing.Point(236, 156);
            this.btAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdd.Name = "btAdd";
            this.btAdd.Primary = true;
            this.btAdd.Size = new System.Drawing.Size(26, 21);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbCatCod
            // 
            this.cbCatCod.FormattingEnabled = true;
            this.cbCatCod.Location = new System.Drawing.Point(6, 156);
            this.cbCatCod.Name = "cbCatCod";
            this.cbCatCod.Size = new System.Drawing.Size(232, 21);
            this.cbCatCod.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(2, 137);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Nome da Categoria";
            // 
            // frmCadastroSubCategoria2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 489);
            this.Name = "frmCadastroSubCategoria2";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria2_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btAdd;
        private System.Windows.Forms.ComboBox cbCatCod;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
