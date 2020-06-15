using ApiSortidas.Application.Querys.ViewModels;
using ApiSortidas.Infra;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiSortidas.Application.Querys.Queries.ObtemTodosUsuarios
{
    public class ObtemTodosUsuariosQueryHandle : IRequestHandler<ObtemTodosOsUsuariosQuery, UsuarioViewModel[]>
    {
        private readonly Context _context;

        public ObtemTodosUsuariosQueryHandle(Context context)
        {
            _context = context;
        }

        public async Task<UsuarioViewModel[]> Handle(ObtemTodosOsUsuariosQuery request, CancellationToken cancellationToken)
        {

            return await _context.Usuarios.Select(uso => new UsuarioViewModel()
            {
                Nome = uso.Usuario,
                Email = uso.Email,
                Role = uso.Role,
            }).ToArrayAsync();
        }
    }
}
