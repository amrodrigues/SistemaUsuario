using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Projeto.Business.Utils
{
    public static class Mensageria
    {
        public static void EnviarLembreteDeSenha(Usuario u, string novaSenha)
        {
            string conta = "cotiexemplo@gmail.com";
            string senha = "@coticoti@";

            MailMessage msg = new MailMessage(conta, u.Email);
            msg.Subject = "Nova senha atualizada com sucesso";

            StringBuilder texto = new StringBuilder();
            texto.Append("<h4>Nova senha gerada com sucesso</h4>");
            texto.Append($"Olá {u.Username}, sua senha para acesso é:<br/><br/>");
            texto.Append($"<strong>{novaSenha}</strong>");
            texto.Append("<br/><br/>");
            texto.Append("Att<br/>Equipe Sistema Modelo");

            msg.Body = texto.ToString();
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true; //SSL - Security Socket Layer
            client.Credentials = new NetworkCredential(conta, senha);
            client.Send(msg); //enviando o email..
        }
    }
}
