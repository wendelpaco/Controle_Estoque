using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal2 : MaterialForm
    {
        bool _logOUt;
        public frmPrincipal2()
        {
            InitializeComponent();
            frmLogin f = new frmLogin();
            f.interface_();
        }
        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            this.Painel_Cadastro.Controls.Clear();
            frmCadastroCategoria2 f = new frmCadastroCategoria2();
            f.TopLevel = false;
            this.Painel_Cadastro.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }
        private void BtnSubCategoria_Click(object sender, EventArgs e)
        {
            this.Painel_Cadastro.Controls.Clear();
            frmCadastroSubCategoria2 f = new frmCadastroSubCategoria2();
            f.TopLevel = false;
            this.Painel_Cadastro.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }
        private void BtnUnidadeMedida_Click(object sender, EventArgs e)
        {
            this.Painel_Cadastro.Controls.Clear();
            frmCadastrounidadeDeMedida f = new frmCadastrounidadeDeMedida();
            f.TopLevel = false;
            this.Painel_Cadastro.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }
        private void BtnProtudo_Click(object sender, EventArgs e)
        {
            this.Painel_Cadastro.Controls.Clear();
            frmCadastroProduto f = new frmCadastroProduto();
            f.TopLevel = false;
            this.Painel_Cadastro.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            this.Painel_Cadastro.Controls.Clear();
            frmCadastroCliente f = new frmCadastroCliente();
            f.TopLevel = false;
            this.Painel_Cadastro.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }
        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            this.Painel_Cadastro.Controls.Clear();
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.TopLevel = false;
            this.Painel_Cadastro.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }
        private void BtnTipoPagamento_Click(object sender, EventArgs e)
        {
            this.Painel_Cadastro.Controls.Clear();
            frmCadastroTipoPagamento f = new frmCadastroTipoPagamento();
            f.TopLevel = false;
            this.Painel_Cadastro.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }
        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            this.Painel_Cadastro.Controls.Clear();
            frmCadastroUsuario f = new frmCadastroUsuario();
            f.TopLevel = false;
            this.Painel_Cadastro.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }
        private void frmPrincipal2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_logOUt)
            Application.Exit();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            _logOUt = true;
            this.Close();
            frmLogin.Instace.Show();
        }
    }
}
