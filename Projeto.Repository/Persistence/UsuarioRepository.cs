using Projeto.Entities;
using Projeto.Repository.Context;
using Projeto.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Persistence
{
    public class UsuarioRepository
        : BaseRepository<Usuario>, IUsuarioRepository
    {
        public bool HasEmail(string email)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Usuario.Count(u => u.Email.Equals(email)) > 0;
            }
        }

        public Usuario Find(string email, string senha)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Usuario
                        .FirstOrDefault(u => u.Email.Equals(email)
                                          && u.Senha.Equals(senha));
            }
        }

        public Usuario Find(string email)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Usuario
                        .FirstOrDefault(u => u.Email.Equals(email));
            }
        }
    }
}
