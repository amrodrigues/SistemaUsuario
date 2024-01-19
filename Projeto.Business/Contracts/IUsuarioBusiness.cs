using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Contracts
{
    public interface IUsuarioBusiness :IBaseBusiness<Usuario>
    {
        void CriarConta(Usuario u);

        Usuario Autenticar(string email, string senha);

        Usuario ObterDados(string email, string senha);

        void GerarNovaSenha(string email);

        void RedefinirSenha(string email, string senhaAtual, string senhaNova);
    }
}
