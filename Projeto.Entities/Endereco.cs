using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public int Cep { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        
        public Endereco()
        { }

        public Endereco(int idendereco, string logradouro, string numero,int cep, string complemento, string cidade, string estado)
        {
            IdEndereco = idendereco;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
