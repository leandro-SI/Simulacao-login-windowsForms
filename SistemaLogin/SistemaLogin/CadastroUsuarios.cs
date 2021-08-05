using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    public static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario("leandro", "123"),  
            new Usuario("luciana", "321")
        
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach(Usuario user in usuarios)
            {
                if (user.Nome.Equals(nome) && user.Senha.Equals(senha))
                {
                    UsuarioLogado = user;
                    return true;
                }
            }

            return false;
        }
    }
}
