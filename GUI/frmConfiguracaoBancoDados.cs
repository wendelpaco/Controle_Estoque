using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmConfiguracaoBancoDados : Form
    {
        public frmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }

        private void frmConfiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                var path = @"C:\SoftWare_Vendas\ConfiguracaoBancoDados.txt";

                StreamReader arquivo = new StreamReader(path);
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (Exception erro)
            {
                // qndo nao houver arquivo de conf, ao tentar ler sempre vai tomar erro.
                //então deixo sem exibe o erro

                //MessageBox.Show(erro.Message);
            }
        }
        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var dir = @"C:\SoftWare_Vendas";
                var path = @"C:\SoftWare_Vendas\ConfiguracaoBancoDados.txt";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                if (File.Exists(path))
                {
                    StreamWriter escrever = new StreamWriter(path, false);
                    escrever.WriteLine(txtServidor.Text);
                    escrever.WriteLine(txtBanco.Text);
                    escrever.WriteLine(txtUsuario.Text);
                    escrever.WriteLine(txtSenha.Text);
                    escrever.Close();
                    MessageBox.Show("Arquivo atualizado com sucesso!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                else
                {
                    File.Create(path).Close();
                    StreamWriter escrever = new StreamWriter(path, false);
                    escrever.WriteLine(txtServidor.Text);
                    escrever.WriteLine(txtUsuario.Text);
                    escrever.WriteLine(txtSenha.Text);
                    escrever.WriteLine(txtBanco.Text);
                    escrever.Close();
                    MessageBox.Show("Arquivo atualizado com sucesso!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btTestar_Click_1(object sender, EventArgs e)
        {
            try
            {

                DadosDaConexao.servidor = txtServidor.Text;
                DadosDaConexao.banco = txtBanco.Text;
                DadosDaConexao.usuario = txtUsuario.Text;
                DadosDaConexao.senha = txtSenha.Text;
                //testar a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conexão efetuada com sucesso.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                                "       Verifique os dados informados.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }
    }
}
