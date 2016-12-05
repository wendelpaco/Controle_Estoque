using BLL;
using DAL;
using Ferramentas;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : MaterialForm
    {
        static frmLogin _intance;
        public static frmLogin Instace
        {
            get
            {
                if (_intance == null)
                    _intance = new frmLogin();
                return _intance;
            }
        }
        public frmLogin()
        {
            InitializeComponent();
            interface_();
        }
        public void interface_()
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightBlue900, Accent.Teal700, TextShade.WHITE);
            Status.Visible = false;
            Erro.Visible = false;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //verifica conexao com o banco
            try
            {
                var path = @"C:\SoftWare_Vendas\ConfiguracaoBancoDados.txt";
                _intance = this;
                StreamReader arquivo = new StreamReader(path);
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                //testar a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("                  Erro ao se conectar no banco de dados. \r\n" +
                                "   Acesse as configurações e informe os parâmetros de conexao. \r\n" +
                                "                Menu: Ferramentas -> Configuracao de Banco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrincipal2 f = null;
                string senha = Cryptography.PasswordMD5(TxtSenha.Text);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                bll.Logar(TxtUsuario.Text, senha);
                if (DALUsuario.valor != 0)
                {
                    f = new frmPrincipal2();
                    f.Show();
                    this.Hide();
                    TxtUsuario.Clear();
                    TxtUsuario.Focus();
                    TxtSenha.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    frmPrincipal2 f = null;
                    string senha = Cryptography.PasswordMD5(TxtSenha.Text);
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    bll.Logar(TxtUsuario.Text, senha);
                    if (DALUsuario.valor != 0)
                    {
                        f = new frmPrincipal2();
                        f.Show();
                        this.Hide();
                        TxtUsuario.Clear();
                        TxtUsuario.Focus();
                        TxtSenha.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*   private void MoverProgressBar(object sender, EventArgs e)
           {
               int contar = 1;
               //
               // Mover a progress bar através da alteração do VALUE
               //
               Carregando.Value = 0;     // Esse é o valor da progress bar ela vai de 0 a Maximum (padrão 100)
               Carregando.Maximum = 1000; // Esse é o valor Maximo da progress bar, então quando value for = a 1000 ele vai ter carregado 100% (Por parão o maximum = 100)
               while (contar <= 1000)
               {
                   Carregando.Value = contar;
                   contar++;
               }
               //
               // Mover a progress bar através do metodo PerformStep
               //
               Carregando.Maximum = 1000;
               Carregando.Step = 1;      // Esse é o valor que a progress bar vai subir quando você char a methodo PerformStep então ela vai ser incrementada esse valor até atingir o valor Maximum
               Carregando.Value = 0;
               contar = 1;
               while (contar <= 1000)
               {
                   Carregando.PerformStep();
                   contar++;
               }
               MessageBox.Show("Seja bem vindo(a).","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
               Carregando.Value = 0; //Zera a progress bar
           }*/
    }
}
