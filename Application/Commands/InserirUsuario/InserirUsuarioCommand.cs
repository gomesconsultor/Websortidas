using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSortidas.Application.Commands.InserirUsuario
{
    public class InserirUsuarioCommand: IRequest
    {
        public InserirUsuarioCommand(string usuario, string email, string password, string role)
        {
            Username = usuario;
            Email = email;
            Password = password;
            Role = role;


        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
