using Listando.Models;
using Listando.Services.Repositories.Interfaces;

namespace Listando.Services.Repositories
{
    public class MercadoRepository : IMercadoRepository
    {
        public Task<MercadoModel> AdicionarMercadoAsync(MercadoModel mercado)
        {
            throw new NotImplementedException();
        }

        public Task<MercadoModel> AtualizarMercadoAsync(MercadoModel mercado, int id)
        {
            throw new NotImplementedException();
        }

        public Task<MercadoModel> BuscarMercadoPorIdAsync(int mercadoId)
        {
            throw new NotImplementedException();
        }

        public Task<List<MercadoModel>> BuscarPorPalavraChaveAsync(string palavraChave)
        {
            throw new NotImplementedException();
        }

        public Task<List<MercadoModel>> BuscarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
