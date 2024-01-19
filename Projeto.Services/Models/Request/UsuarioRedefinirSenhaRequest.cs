using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Request
{
    public class UsuarioRedefinirSenhaRequest
    {
        [Required(ErrorMessage = "Email obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha atual obrigatório.")]
        public string SenhaAtual { get; set; }

        [MinLength(6, ErrorMessage = "Senha deve conter no mínimo {1} caracteres")]
        [MaxLength(20, ErrorMessage = "Senha deve conter no máximo {1} caracteres")]
        [Required(ErrorMessage = "Senha nova obrigatório.")]
        public string SenhaNova { get; set; }

        [MinLength(6, ErrorMessage = "Senha deve conter no mínimo {1} caracteres")]
        [MaxLength(20, ErrorMessage = "Senha deve conter no máximo {1} caracteres")]
        [Required(ErrorMessage = "Confirmação de Senha nova obrigatório.")]
        public string ConfirmacaoSenhaNova { get; set; }
    }
}