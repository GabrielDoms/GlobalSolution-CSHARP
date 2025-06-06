using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_C_.Models
{
    // Classe que representa um usuário do sistema.
    public class Usuario
    {
        // Login do usuário.
        public string Login { get; private set; }

        // Senha do usuário.
        public string Senha { get; private set; }

        // Construtor que inicializa o usuário com login e senha.
        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        // Método que autentica o usuário comparando login e senha.
        public bool Autenticar(string login, string senha)
        {
            return Login == login && Senha == senha;
        }
    }
}

