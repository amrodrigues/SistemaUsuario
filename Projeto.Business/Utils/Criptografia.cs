using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Utils
{
    public static class Criptografia
    {
        public static string EncriptarSenha(string senha)
        {
            //algoritmo de criptografia baseado em HASH..
            //MD5 retorna 32 caracteres em formatro Hexadecimal
            MD5 md5 = new MD5CryptoServiceProvider();

            //converter a senha para bytes..
            byte[] senhaEmBytes = Encoding.UTF8.GetBytes(senha);

            //criptografar a senha..
            byte[] hash = md5.ComputeHash(senhaEmBytes);

            //transformar de bytes para string hexadecimal..
            string resultado = string.Empty;

            foreach(byte b in hash) //varrendo cada byte..
            {
                resultado += b.ToString("X2"); //X2 -> HEXADECIMAL..
            }

            return resultado;
        }
    }
}
