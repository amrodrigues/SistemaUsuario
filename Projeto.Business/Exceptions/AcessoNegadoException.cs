using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Exceptions
{
    public class AcessoNegadoException : Exception
    {
        //sobrescrita de método..
        public override string Message 
            => "Acesso Negado. Usuário não encontrado.";
    }
}
