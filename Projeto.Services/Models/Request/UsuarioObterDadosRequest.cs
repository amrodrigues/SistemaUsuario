using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Request
{
    public class UsuarioObterDadosRequest
    {
        [Required(ErrorMessage = "Email obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha obrigatória.")]
        public string Senha { get; set; }
    }
}