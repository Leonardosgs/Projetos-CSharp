using Listando.Models;
using Listando.Services.Repositories.Interfaces;

namespace Listando.Services.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        public Task<MarcaModel> AdicionarMarcaAsync(MarcaModel marca)
        {
            throw new NotImplementedException();
        }

        public Task<MarcaModel> AtualizarMarcaAsync(MarcaModel marca)
        {
            throw new NotImplementedException();
        }

        public Task<MarcaModel> BuscarMarcaPorIdAsync(int marcaId)
        {
            throw new NotImplementedException();
        }

        public Task<List<MarcaModel>> BuscarPorPalavraChaveAsync(string palavraChave)
        {
            throw new NotImplementedException();
        }

        public Task<List<MarcaModel>> BuscarTodasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverMarcaAsync(MarcaModel marca)
        {
            throw new NotImplementedException();
        }
    }
}
