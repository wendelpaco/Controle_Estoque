namespace GUI
{
    partial class frmConsultaCompra
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
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.pnFornecedor = new System.Windows.Forms.Panel();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.btLocalizarFornecedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNomeFornecedor = new System.Windows.Forms.Label();
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pnFornecedor.SuspendLayout();
            this.gbBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGeral);
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.rbFornecedor);
            this.groupBox1.Controls.Add(this.rbParcelas);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(573, 65);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar pelo:";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(12, 27);
            this.rbGeral.Margin = new System.Windows.Forms.Padding(2);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(113, 17);
            this.rbGeral.TabIndex = 3;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as Compras";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(295, 27);
            this.rbData.Margin = new System.Windows.Forms.Padding(2);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(103, 17);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data da Compra";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Location = new System.Drawing.Point(170, 27);
            this.rbFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(80, 17);
            this.rbFornecedor.TabIndex = 0;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Location = new System.Drawing.Point(443, 27);
            this.rbParcelas.Margin = new System.Windows.Forms.Padding(2);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(121, 17);
            this.rbParcelas.TabIndex = 2;
            this.rbParcelas.Text = "Parcelas  em Aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            this.rbParcelas.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(7, 139);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(573, 306);
            this.dgvDados.TabIndex = 12;
            // 
            // pnFornecedor
            // 
            this.pnFornecedor.Controls.Add(this.txtForCod);
            this.pnFornecedor.Controls.Add(this.btLocalizarFornecedor);
            this.pnFornecedor.Controls.Add(this.lbNomeFornecedor);
            this.pnFornecedor.Controls.Add(this.label1);
            this.pnFornecedor.Location = new System.Drawing.Point(4, 13);
            this.pnFornecedor.Name = "pnFornecedor";
            this.pnFornecedor.Size = new System.Drawing.Size(563, 50);
            this.pnFornecedor.TabIndex = 14;
            this.pnFornecedor.Visible = false;
            // 
            // txtForCod
            // 
            this.txtForCod.Enabled = false;
            this.txtForCod.Location = new System.Drawing.Point(3, 23);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(448, 21);
            this.txtForCod.TabIndex = 16;
            // 
            // btLocalizarFornecedor
            // 
            this.btLocalizarFornecedor.Location = new System.Drawing.Point(448, 22);
            this.btLocalizarFornecedor.Name = "btLocalizarFornecedor";
            this.btLocalizarFornecedor.Size = new System.Drawing.Size(116, 23);
            this.btLocalizarFornecedor.TabIndex = 17;
            this.btLocalizarFornecedor.Text = "&Localizar Fornecedor";
            this.btLocalizarFornecedor.UseVisualStyleBackColor = true;
            this.btLocalizarFornecedor.Click += new System.EventHandler(this.btLocalizarFornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código do Fornecedor";
            // 
            // lbNomeFornecedor
            // 
            this.lbNomeFornecedor.AutoSize = true;
            this.lbNomeFornecedor.Location = new System.Drawing.Point(176, 9);
            this.lbNomeFornecedor.Name = "lbNomeFornecedor";
            this.lbNomeFornecedor.Size = new System.Drawing.Size(111, 13);
            this.lbNomeFornecedor.TabIndex = 18;
            this.lbNomeFornecedor.Text = "Nome do Fornecedor:";
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.pnFornecedor);
            this.gbBox.Location = new System.Drawing.Point(7, 65);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(573, 70);
            this.gbBox.TabIndex = 15;
            this.gbBox.TabStop = false;
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDados);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Compras";
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pnFornecedor.ResumeLayout(false);
            this.pnFornecedor.PerformLayout();
            this.gbBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.Panel pnFornecedor;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Button btLocalizarFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNomeFornecedor;
        private System.Windows.Forms.GroupBox gbBox;
    }
}