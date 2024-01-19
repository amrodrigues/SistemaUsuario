using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Imagem { get; set; }

        public Usuario()
        {
            
        }

        public Usuario(int idusuario ,string username, string email, string telefone, string senha ,string imagem)
        {
            IdUsuario = idusuario;
            Username = username;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            Imagem = imagem;

        }
    }
}
