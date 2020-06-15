using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSortidas.REST.Payloads
{
    public class InsereUsuarioPayload
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        
        public string Role { get; set; }

    }
}
