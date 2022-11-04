using Listando.Data;
using Listando.Models;
using Listando.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Listando.Services.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SistemaDbContext _dbContext;

        public UsuarioRepository(SistemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuariosAsync()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> BuscarUsuarioPorIdAsync(int usuarioId)
        {
            return await _dbContext.Usuarios.Where(u => u.Id == usuarioId).FirstOrDefaultAsync();
        }

        public async Task<UsuarioModel> BuscarUsuarioPorEmailAsync(string email)
        {
            return await _dbContext.Usuarios.Where(u => u.Email == email).FirstOrDefaultAsync();
        }

        public async Task<List<UsuarioModel>> BuscarUsuarioPorPalavraChaveAsync(string palavraChave)
        {
            return await _dbContext.Usuarios.Where(u => u.Nome.StartsWith(palavraChave, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();
        }

        public async Task<UsuarioModel> AdicionarUsuarioAsync(UsuarioModel usuario)
        {
            await _dbContext.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;

        }

        public async  Task<UsuarioModel> AtualizarUsuarioAsync(UsuarioModel usuario)
        {
            UsuarioModel u = await BuscarUsuarioPorIdAsync(usuario.Id);
            
            if(u == null)
            {
                throw new Exception($"Usuario no id: {usuario.Id} não encontrado.");
            }
            _dbContext.Usuarios.Update(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<bool> RemoverUsuarioAsync(int userId)
        {
            UsuarioModel u = await BuscarUsuarioPorIdAsync(userId);

            if(u == null)
            {
                throw new Exception($"Usuario no id: {userId} não encontrado.");
            }
            _dbContext.Usuarios.Remove(u);
            return true;
        }
    }
}
