using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Request
{
    public class UsuarioLembrarSenhaRequest
    {
        [Required(ErrorMessage = "Por favor, informe o email do usuário.")]
        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        public string Email { get; set; }
    }
}