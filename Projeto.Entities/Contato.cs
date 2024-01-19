using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Contato
    {
        public int IdContato { get; set; }
        public string Nome { get; set; }
        public string DesContato { get; set; }
        public TipoContato TipoContato { get; set; }

        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public Contato()
        { }
    
        public Contato( int idcontato, string nome , string descontato, TipoContato tipocontato)
        {
            IdContato = idcontato;
            Nome = nome;
            DesContato = descontato;
            TipoContato = tipocontato;
        }
    }
}
