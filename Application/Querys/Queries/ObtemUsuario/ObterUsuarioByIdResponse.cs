using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSortidas.Application.Querys.Queries.ObtemUsuario
{
    public class ObterUsuarioByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Role { get; set; }

    }
}
