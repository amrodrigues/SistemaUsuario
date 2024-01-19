using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Exceptions
{
    //classe de exceção customizada..
    public class EmailJaCadastradoException : Exception
    {
        //atributo..
        private string email;

        //construtor com entrada de argumentos..
        public EmailJaCadastradoException(string email)
        {
            this.email = email;
        }

        //sobrescrita de método..
        public override string Message 
            => $"O email {email} já encontra-se cadastrado. Tente outro.";
    }
}
