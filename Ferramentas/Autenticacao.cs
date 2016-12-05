using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class Autenticacao{
        static int codUsuario;
        static string nomeUsuario;
        static string loginUse;
        static string senha;
        static int codPerfil;
        static int flgAtivo;
        
        public static void login(int _codUsuario, string _nomeUsuario, string _loginUse, string _senha, int _fltAtivo, int _codPerfil){
            codUsuario = _codUsuario;
            nomeUsuario = _nomeUsuario;
            loginUse = _loginUse;
            senha = _senha;
            flgAtivo = _fltAtivo;
            codPerfil = _codPerfil;
            
                
        }
        public static void logout(){
            codUsuario = 0;
            nomeUsuario = null;
            loginUse = null;
            senha = null;
            flgAtivo = 1;
            codPerfil = 0;
            
        }
        public static String getUsuario(){
            return nomeUsuario;
        }
        public static String getCodUsuario(){
            return codUsuario.ToString();
        }
        public static String getCodPerfil(){
            return codPerfil.ToString();
        }
       
    }
}
