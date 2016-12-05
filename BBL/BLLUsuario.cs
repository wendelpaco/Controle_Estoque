using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório");
            }
            if(modelo.Usuario.Trim().Length == 0)
            {
                throw new Exception("O Login é obrigatório");
            }
            if (modelo.Senha.Trim().Length == 0)
            {
                throw new Exception("A campo senha é obrigatória");
            }
            if (modelo.ConfSenha.Trim().Length == 0)
            {
                throw new Exception("A campo Confirmar senha é obrigatória");
            }
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.Email))
            {
                throw new Exception("Digite um email válido.");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloUsuario modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório");
            }
            if (modelo.Usuario.Trim().Length == 0)
            {
                throw new Exception("O Login é obrigatório");
            }
            if (modelo.Senha.Trim().Length == 0)
            {
                throw new Exception("A campo senha é obrigatória");
            }
            if (modelo.ConfSenha.Trim().Length == 0)
            {
                throw new Exception("O campo confirmar senha é obrigatória");
            }
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.Email))
            {
                throw new Exception("Digite um E-mail válido.");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Excluir(codigo);
        }
        public void Logar(string obj, string obj2)
        {
            if (obj.Trim().Length == 0 || obj2.Trim().Length == 0)
            {
                throw new Exception("Preencha os campos para logar.");
            }
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Logar(obj, obj2);
        }
        public DataTable Localizar(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarPerfilAtivo(valor);
        }
        public DataTable LocalizarPorNome(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            /*if (valor.Length == 0)
            {
                throw new Exception("Preencha o campo para realizar a pesquisa.");
            }
            */
            return DALobj.LocalizarPorNome(valor);
        }
        public DataTable LocalizarLoginAtivo(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
           /* if (valor.Length == 0)
            {
                throw new Exception("Preencha o campo para realizar a pesquisa.");
            }
            */
            return DALobj.LocalizarLoginAtivo(valor);
        }
        public DataTable LocalizarUsuariosInativos (string valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            /*if (valor.Length == 0)
            {
                throw new Exception("Preencha o campo para realizar a pesquisa.");
            }
            */
            return DALobj.LocalizarUsuariosInativos(valor);
        }
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuario(codigo);
        }

    }
}
