using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroUsuario : Form
    {
        public String operacao;

        private DALConexao conexao;
        public frmCadastroUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }
        public void alteraBotoes(int op)
        {
            // op = operaçoes que serao feitas com os botoes
            // 1  = Preparar os botoes para inserir e localizar
            // 2  = preparar os para inserir/alterar um registro
            // 3  = preparar a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }
        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            cbPerfil.DataSource = bll.Localizar("");
            cbPerfil.DisplayMember = "nme_perfil";
            cbPerfil.ValueMember = "cod_perfil";
            cbPerfil.SelectedIndex = 0;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.Nome = txtNome.Text;
                modelo.Usuario = txtUsuario.Text;
                modelo.Email = txtEmail.Text;
                modelo.Senha = txtSenha.Text;
                modelo.ConfSenha = txtConfirmaSenha.Text;
                modelo.Perfil = Convert.ToInt32(cbPerfil.SelectedValue);
                if (rbAtivo.Checked == true)
                {
                    modelo.FlgAtivo = 1; // cliente ativo
                }
                else
                {
                    modelo.FlgAtivo = 0; // cliente inativo
                }
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                if (modelo.Senha == modelo.ConfSenha)
                {
                    if (this.operacao == "inserir")
                    {
                        //Cadastra um usuario
                        modelo.Senha = Cryptography.PasswordMD5(this.txtSenha.Text); //adc cryptografa ao gravar a senha 
                        bll.Incluir(modelo);
                        MessageBox.Show("Usuário cadastrado com sucesso: Código " + modelo.CodUsuario, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //alterar um usuario
                        modelo.CodUsuario = Convert.ToInt32(txtCodigo.Text);
                        modelo.Senha = this.txtSenha.Text; //adc cryptografa ao alterar a senha 
                        bll.Alterar(modelo);
                        MessageBox.Show("Usuário alterado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void rbM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbM.Checked == true)
            {
                pbFotoM.Visible = true;
                pbFotoF.Visible = false;
            }
            else
            {
                pbFotoM.Visible = false;
                pbFotoF.Visible = true;
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = bll.CarregaModeloUsuario(f.codigo);
                txtCodigo.Text = modelo.CodUsuario.ToString();
                if (modelo.FlgAtivo == 1)
                {
                    rbAtivo.Checked = true;
                }
                else
                {
                    rbInativo.Checked = true;
                }
                txtNome.Text = modelo.Nome;
                txtUsuario.Text = modelo.Usuario;
                txtEmail.Text = modelo.Email;
                txtSenha.Text = modelo.Senha;
                txtConfirmaSenha.Text = modelo.ConfSenha;
                cbPerfil.SelectedValue = modelo.Perfil;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
            rbM.Checked = true;
        }
        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtUsuario.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
            cbPerfil.SelectedIndex = 0;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //DALUsuario dao = new DALUsuario(conexao);
                //BLLUsuario bll2 = new BLLUsuario(conexao); 
                ModeloUsuario modelo = new ModeloUsuario();
                int Ativo;

                Ativo = modelo.FlgAtivo;
                if(Ativo == 1)
                {
                    DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLUsuario bll = new BLLUsuario(cx);
                        bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                        this.LimpaTela();
                        this.alteraBotoes(1);
                        MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                //MessageBox.Show("Não é possível excluir um cliente INATIVO!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Não é possível excluir um cliente INATIVO!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.alteraBotoes(3);
            }
        }

        private void btAddPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contate o Administrador para poder cadastrar um perfil! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
