using Projeto.Entities;
using Projeto.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Persistence
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
    }
}
