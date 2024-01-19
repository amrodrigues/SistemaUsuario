using Projeto.Business.Contracts;
using Projeto.Entities;
using Projeto.Services.Models.Request;
using Projeto.Services.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.Services.Controllers
{
    
        [RoutePrefix("api/usuario")]
        public class UsuarioController : ApiController
        {
            //atributo..
            private IUsuarioBusiness business;

            //construtor para injeção de dependencia..
            public UsuarioController(IUsuarioBusiness business)
            {
                this.business = business;
            }

            //serviço para criar a conta dos usuarios..
            [HttpPost] //requisição POST
            [Route("criarconta")] //URL: /api/usuario/criarconta
            public HttpResponseMessage CriarConta(UsuarioCriarContaRequest request)
            {
                if (ModelState.IsValid)
                {
                    UsuarioCriarContaResponse response = new UsuarioCriarContaResponse();

                    try
                    {
                        Usuario u = new Usuario();
                        u.Username = request.Username;
                        u.Email = request.Email;
                        u.Senha = request.Senha;
                        u.Telefone = request.Telefone;
                        u.Imagem = request.Imagem;

                        business.CriarConta(u); //gravando..

                        response.Mensagem = "Conta de usuario criada com sucesso.";
                        return Request.CreateResponse(HttpStatusCode.OK, response);
                    }
                    catch (Exception e)
                    {
                        response.Mensagem = "Ocorreu um erro: " + e.Message;
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, response);
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }


            [HttpPost]
            [Route("lembrarsenha")]
            public HttpResponseMessage LembrarSenha(UsuarioLembrarSenhaRequest request)
            {
                if (ModelState.IsValid)
                {
                    UsuarioLembrarSenhaResponse response = new UsuarioLembrarSenhaResponse();

                    try
                    {
                        business.GerarNovaSenha(request.Email);
                        response.Mensagem = "Nova senha gerada com sucesso. Verifique seu email.";

                        return Request.CreateResponse(HttpStatusCode.OK, response);
                    }
                    catch (Exception e)
                    {
                        response.Mensagem = "Ocorreu um erro: " + e.Message;
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, response);
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }


            [Authorize]
            [HttpPost]
            [Route("redefinirsenha")]
            public HttpResponseMessage RedefinirSenha(UsuarioRedefinirSenhaRequest request)
            {
                UsuarioRedefinirSenhaResponse response = new UsuarioRedefinirSenhaResponse();

                if (ModelState.IsValid)
                {
                    try
                    {
                        //senhas estao corretas?
                        if (request.SenhaNova.Equals(request.ConfirmacaoSenhaNova))
                        {
                            business.RedefinirSenha(request.Email, request.SenhaAtual, request.SenhaNova);
                            response.Mensagem = "Senha atualizada com sucesso.";

                            return Request.CreateResponse(HttpStatusCode.OK, response);
                        }
                        else
                        {
                            response.Mensagem = "Senhas não conferem";
                            return Request.CreateResponse(HttpStatusCode.BadRequest, response);
                        }
                    }
                    catch (Exception e)
                    {
                        response.Mensagem = e.Message;
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, response);
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }

            [Authorize]
            [HttpPost]
            [Route("obterdados")]
            public HttpResponseMessage ObterDadosUsuario(UsuarioObterDadosRequest request)
            {
                UsuarioObterDadosResponse response = new UsuarioObterDadosResponse();

                try
                {
                    Usuario u = business.ObterDados(request.Email, request.Senha);

                    response.IdUsuario = u.IdUsuario;
                    response.Username = u.Username;
                    response.Email = u.Email;
                   
                    response.Mensagem = "Usuário encontrado com sucesso.";

                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                catch (Exception e)
                {
                    response.Mensagem = e.Message;
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, response);
                }
            }

        }
    }
