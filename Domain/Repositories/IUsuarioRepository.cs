using ApiSortidas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSortidas.Application.Querys.ViewModels;

namespace ApiSortidas.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<User> Insere(User user);
        Task<User> ObterPorId(int id);
        Task<User> Apaga(int id);
        Task<User> Atualiza(int id);
    }
}
