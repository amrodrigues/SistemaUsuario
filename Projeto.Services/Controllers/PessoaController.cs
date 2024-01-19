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
    [RoutePrefix("api/pessoa")]
    public class PessoaController : ApiController
    {
        //atributo..
        private IPessoaBusiness business;

        //construtor para injeção de dependencia..
        public PessoaController(IPessoaBusiness business)
        {
            this.business = business;
        }

        //serviço para criar a conta dos usuarios..
        [HttpPost] //requisição POST
        [Route("cadastrar")] //URL: /api/usuario/criarconta
        public HttpResponseMessage CriarConta(PessoaCadastrarContaRequest request)
        {
            if (ModelState.IsValid)
            {
                PessoaCadastrarContaResponse response = new PessoaCadastrarContaResponse();

                try
                {
                    Pessoa p = new Pessoa();
                    p.Nome = request.Nome;
                    p.Sobrenome = request.Sobrenome;
                    p.RG = request.RG;
                    p.CPF = request.CPF;


                    business.Cadastrar(p); //gravando..

                    response.Mensagem = "Pessoa criada com sucesso.";
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
    }
}
