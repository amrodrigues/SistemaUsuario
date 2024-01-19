using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public  class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

        public List<Contato> Contatos { get; set; }
        public List<Endereco> Enderecos { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int idPessoa, string nome, string sobrenome, string email, DateTime datanascimento, string cpf, string rg)
        {
            IdPessoa = idPessoa;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = datanascimento;
            CPF = cpf;
            RG = rg;
        }
    }
}
