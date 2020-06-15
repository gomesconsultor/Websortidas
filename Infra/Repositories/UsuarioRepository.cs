using ApiSortidas.Domain.Entities;
using ApiSortidas.Domain.Repositories;
using ApiSortidas.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiSortidas.Application.Querys.ViewModels;
using ApiSortidas.Services;
using ApiSortidas.REST.Payloads;

namespace ApiSortidas.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context _context;

        public UsuarioRepository(Context context)
        {
            _context = context;
        }

        public Task<User> Apaga(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Atualiza(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Insere(User user)
        {
            _context.Usuarios.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<LoginViewModel> Login(InsereLoginPayload model)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.Usuario == model.Username && x.Password == model.Password);
            //if (user == null)
              //  return StatusCode(404, "Usuário ou senha inválidos");
            
            var token = TokenService.GenerateToken(model);
            model.Password = "";
            

            var retorno = new LoginViewModel();
            if (user == null)

                return null;

            retorno.Nome = model.Username;
            //retorno.Email = model.Email;
            retorno.token = token;

            return retorno;




        }
        public async Task<User> ObterPorId(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id.Equals(id)); ;
            
        }
    }
}
