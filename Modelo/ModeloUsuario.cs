using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        //propriedades da classe
        private int codUsuario;
        private string nome;
        private string usuario;
        private string senha;
        private string email;
        private string confSenha;
        private int flgAtivo;
        private int perfil;

        public int CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ConfSenha
        {
            get { return confSenha; }
            set { confSenha = value; }
        }
        public int FlgAtivo
        {
            get { return flgAtivo; }
            set { flgAtivo = value; }
        }
        public int Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        //construtores
        public ModeloUsuario()
        {
            this.codUsuario = 0;
            this.nome = "";
            this.usuario = "";
            this.senha = "";
            this.email = "";
            this.confSenha = "";
            this.flgAtivo = 0;
            this.perfil = 0;
        }
        public ModeloUsuario(int _codUsuario, string _nome, string _usuario, string _senha, string _email, string _confSenha, int _flgAtivo ,int _perfil)
        {
            this.codUsuario = _codUsuario;
            this.nome = _nome;
            this.usuario = _usuario;
            this.senha = _senha;
            this.email = _email;
            this.confSenha = _confSenha;
            this.flgAtivo = _flgAtivo;
            this.perfil = _perfil;
        }
    }
}
