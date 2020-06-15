using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSortidas.Application.Querys.ViewModels
{
    public class LoginViewModel
    {
        public string Nome { get; set; }
        public string Password { get; set; }

        
        public string Role { get; set; }

        public string token { get; set; }
    }
}
