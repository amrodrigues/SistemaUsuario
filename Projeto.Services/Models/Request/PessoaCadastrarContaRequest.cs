using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Request
{
    public class PessoaCadastrarContaRequest
    {
        public string Nome { get; internal set; }
        public string Sobrenome { get; internal set; }
        public string RG { get; internal set; }
        public string CPF { get; internal set; }
    }
}