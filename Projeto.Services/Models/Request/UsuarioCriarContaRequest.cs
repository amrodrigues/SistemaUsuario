using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Request
{
   
        public class UsuarioCriarContaRequest
        {
            [MinLength(3, ErrorMessage = "Nome deve conter no mínimo {1} caracteres")]
            [MaxLength(50, ErrorMessage = "Nome deve conter no máximo {1} caracteres")]
            [Required(ErrorMessage = "Nome obrigatório")]
            public string Unsername { get; set; }

            [EmailAddress(ErrorMessage = "Email inválido")]
            [Required(ErrorMessage = "Email obrigatório")]
            public string Email { get; set; }

            [MinLength(6, ErrorMessage = "Senha deve conter no mínimo {1} caracteres")]
            [MaxLength(20, ErrorMessage = "Senha deve conter no máximo {1} caracteres")]
            [Required(ErrorMessage = "Senha obrigatório")]
            public string Senha { get; set; }
        public string Username { get; internal set; }
        public string Telefone { get; internal set; }
        public string Imagem { get; internal set; }
    }
    }