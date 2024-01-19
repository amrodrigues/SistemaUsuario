using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Contracts
{
    public interface IUsuarioRepository
       : IBaseRepository<Usuario>
    {
        bool HasEmail(string email);

        Usuario Find(string email, string senha);

        Usuario Find(string email);
    }
}
