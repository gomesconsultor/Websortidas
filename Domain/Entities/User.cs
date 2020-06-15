using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApiSortidas.Domain.Entities
{
    public class User : Entity
    {
        Regex regex = new Regex(@"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
        Regex nomex = new Regex(@"/[A-Z][a-z]* [A-Z][a-z]*/");
        private const int QuantidadeMaxima = 30;
        private const int QuantidadeMinima = 6;
        public User(string usuario, string email, string password , string role)
        {
            ValidaUsuario(usuario);
            ValidaEmail(email);
            ValidaSenha(password);

            Usuario = usuario;
            Email = email;
            Password = password;
            Role = role;

            //CreateDate = DateTime.Now;
            //LastUpdate = DateTime.Now;
        }

        private void ValidaSenha(string password)
        {
            if (String.IsNullOrEmpty(password))
                throw new Exception("Senha deve possuir conteudo");
            if (password.Length < QuantidadeMinima)
                throw new Exception("Password deve possuir no mínimo 6");

        }

        private void ValidaUsuario(string usuario)
        {

            //Match match = nomex.Match(usuario);

            if (!Regex.IsMatch(usuario, @"^[\p{L}\p{M}' \.\-]+$"))
               throw new Exception("Nome incorreto");
            if (usuario.Length  > QuantidadeMaxima)
                throw new Exception("usuário deve possuir no máximo 30");
            if (String.IsNullOrEmpty(usuario))
                throw new Exception("usuário deve possuir conteudo");
        }

        private void ValidaEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
                throw new Exception("Email deve possuir conteudo");
            Match match = regex.Match(email);
            if (!match.Success)
                throw new Exception("Email incorreto");
        }

        public string Usuario { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }
       
    }
}
