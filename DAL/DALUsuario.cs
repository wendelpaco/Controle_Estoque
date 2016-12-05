using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;
        public static int valor = 0;
        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuario(nme_usuario, nme_login,senha,email, flg_ativo, cod_perfil) " +
                            " values (@nome_usuario, @nme_login,@senha,@email, @flg_ativo, @cod_perfil); " +
                                        " select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nome_usuario", modelo.Nome);
            cmd.Parameters.AddWithValue("@nme_login", modelo.Usuario);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@flg_ativo", modelo.FlgAtivo);
            cmd.Parameters.AddWithValue("@cod_perfil", modelo.Perfil);

            conexao.Conectar();
            modelo.CodUsuario = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuario set nme_usuario = @nme_usuario, " +
                    " nme_login = @nme_login, senha = @senha, email = @email, " +
                " flg_ativo = @flg_ativo, cod_perfil =@cod_Perfil where cod_usuario = @codigo;";

            cmd.Parameters.AddWithValue("@nme_usuario", modelo.Nome);
            cmd.Parameters.AddWithValue("@nme_login", modelo.Usuario);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@flg_ativo", modelo.FlgAtivo);
            cmd.Parameters.AddWithValue("@cod_perfil", modelo.Perfil);
            cmd.Parameters.AddWithValue("@codigo", modelo.CodUsuario);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuario set flg_ativo = 0 where cod_usuario= @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Logar(String modeloUser, String modeloSenha)
        {
            int cambiarra = 1;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where nme_login = @login and senha=@senha and flg_ativo=1";
            cmd.Parameters.AddWithValue("@login", modeloUser);
            cmd.Parameters.AddWithValue("@senha", modeloSenha);
            conexao.Conectar();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Autenticacao.login(Convert.ToInt32(dr["COD_USUARIO"]), dr["NME_USUARIO"].ToString(), dr["NME_LOGIN"].ToString(), dr["SENHA"].ToString(), Convert.ToInt32(dr["FLG_ATIVO"]), Convert.ToInt32(dr["COD_PERFIL"]));
                valor = 1;
            }
            else if (dr.GetInt32(1) == cambiarra)
            {
                //
                //dr.GetInt32(Convert.ToInt32("FLG_ATIVO"));
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorreto(s).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexao.Desconectar();
        }
        public DataTable LocalizarPerfilAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from perfil where nme_perfil like '%" +
                valor + "%'" + "AND FLG_ATIVO = 1", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorNomeUsuarioAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT U.COD_USUARIO, " +
                "U.NME_USUARIO, " +
                "U.NME_LOGIN, " +
                "U.EMAIL, " +
                "P.NME_PERFIL " +
         "FROM   USUARIO AS U " +
                "INNER JOIN PERFIL AS P " +
                        "ON(U.COD_PERFIL = P.COD_PERFIL) " +
         "WHERE  U.FLG_ATIVO = 1" +
                "AND NME_USUARIO LIKE '%" +
                 valor + "%'" + "ORDER BY COD_USUARIO ASC ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorNome(String valor)
        {
            return LocalizarPorNomeUsuarioAtivo(valor);
        }
        public DataTable LocalizarLoginAtivo(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT U.COD_USUARIO, " +
                "U.NME_USUARIO, " +
                "U.NME_LOGIN, " +
                "U.EMAIL, " +
                "P.NME_PERFIL " +
         "FROM   USUARIO AS U " +
                "INNER JOIN PERFIL AS P " +
                        "ON(U.COD_PERFIL = P.COD_PERFIL) " +
         "WHERE  U.FLG_ATIVO = 1" +
                "AND NME_LOGIN LIKE '%" +
                 valor + "%'" + "ORDER BY COD_USUARIO ASC ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarUsuariosInativos(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT U.COD_USUARIO, " +
                "U.NME_USUARIO, " +
                "U.NME_LOGIN, " +
                "U.EMAIL, " +
                "P.NME_PERFIL " +
         "FROM   USUARIO AS U " +
                "INNER JOIN PERFIL AS P " +
                        "ON(U.COD_PERFIL = P.COD_PERFIL) " +
         "WHERE  U.FLG_ATIVO =" + valor, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where cod_usuario = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CodUsuario = Convert.ToInt32(registro["COD_USUARIO"]);
                modelo.Nome = Convert.ToString(registro["NME_USUARIO"]);
                modelo.Usuario = Convert.ToString(registro["NME_LOGIN"]);
                modelo.Senha = Convert.ToString(registro["SENHA"]);
                modelo.ConfSenha = Convert.ToString(registro["SENHA"]);
                modelo.Email = Convert.ToString(registro["EMAIL"]);
                modelo.FlgAtivo = Convert.ToInt32(registro["FLG_ATIVO"]);
                modelo.Perfil = Convert.ToInt32(registro["COD_PERFIL"]);

            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
