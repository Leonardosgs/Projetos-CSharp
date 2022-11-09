using Listando.Data;
using Listando.Models;
using Listando.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Listando.Services.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly SistemaDbContext _dbContext;

        public async Task<MarcaModel> BuscarMarcaPorIdAsync(int marcaId)
        {
            return await _dbContext.Marcas.Where(m => m.Id == marcaId).FirstOrDefaultAsync();
        }

        public async Task<List<MarcaModel>> BuscarPorPalavraChaveAsync(string nome)
        {
           return await _dbContext.Marcas.Where(m => m.Nome.ToLower().StartsWith(nome.ToLower())).ToListAsync();
        }

        public async Task<List<MarcaModel>> BuscarTodasAsync()
        {
            return await _dbContext.Marcas.ToListAsync();
        }
        public async Task<MarcaModel> AdicionarMarcaAsync(MarcaModel marca)
        {
            await _dbContext.Marcas.AddAsync(marca);
            await _dbContext.SaveChangesAsync();
            return marca;
        }

        public Task<MarcaModel> AtualizarMarcaAsync(MarcaModel marca)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverMarcaAsync(MarcaModel marca)
        {
            throw new NotImplementedException();
        }
    }
}
