using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Response
{
    public class UsuarioObterDadosResponse
    {
        public string Mensagem { get;   set; }
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}