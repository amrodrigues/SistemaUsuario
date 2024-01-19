using Projeto.Business.Contracts;
using Projeto.Business.Exceptions;
using Projeto.Business.Utils;
using Projeto.Entities;
using Projeto.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Domain
{
    public class UsuarioBusiness : IUsuarioBusiness
    {
        //atributo..
        private IUsuarioRepository repository;

        //construtor para injeção de dependencia..
        public UsuarioBusiness(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        public void CriarConta(Usuario u)
        {
            //verificando se o email não esta cadastrado..
            if (!repository.HasEmail(u.Email))
            {
                u.Senha = Criptografia.EncriptarSenha(u.Senha);
               

                repository.Insert(u); //gravando..
            }
            else
            {
                throw new EmailJaCadastradoException(u.Email);
            }
        }

        public Usuario Autenticar(string email, string senha)
        {
            //buscar o usuario pelo email e senha..
            Usuario u = repository.Find(email, Criptografia.EncriptarSenha(senha));

            //verificar se o usuario foi encontrado..
            if (u != null)
            {
                return u; //retornando o usuario..
            }
            else
            {
                throw new AcessoNegadoException();
            }
        }

        public void GerarNovaSenha(string email)
        {
            //buscar o usuario no banco de dados pelo email..
            Usuario u = repository.Find(email);

            //verificar se o usuario foi encontrado..
            if (u != null)
            {
                //gerar uma senha randomica com 6 digitos numericos..
                Random r = new Random();
                String novaSenha = r.Next(0, 999999).ToString("D6");

                //atualizar os dados do usuario no banco..
                u.Senha = Criptografia.EncriptarSenha(novaSenha);
                repository.Update(u);

                //enviando email..
                Mensageria.EnviarLembreteDeSenha(u, novaSenha);
            }
            else
            {
                throw new UsuarioNaoEncontradoException();
            }
        }

        public void RedefinirSenha(string email, string senhaAtual, string senhaNova)
        {
            //buscar o usuario pelo email e senha atual..
            Usuario u = repository.Find(email, Criptografia.EncriptarSenha(senhaAtual));

            //verificar se o usuario foi encontrado..
            if (u != null)
            {
                //atualizar a senha do usuario..
                u.Senha = Criptografia.EncriptarSenha(senhaNova);
                repository.Update(u); //atualizando..
            }
            else
            {
                throw new UsuarioNaoEncontradoException();
            }
        }

        public Usuario ObterDados(string email, string senha)
        {
            Usuario u = repository.Find(email, Criptografia.EncriptarSenha(senha));

            if (u != null)
            {
                return u; //retornando usuario..
            }
            else
            {
                throw new UsuarioNaoEncontradoException();
            }
        }

        public void Cadastrar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public Usuario ConsultaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

