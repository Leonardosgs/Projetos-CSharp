using Listando.Models;
using System.Globalization;

namespace Listando.Services.Repositories.Interfaces
{
    public interface IMercadoRepository
    {
        Task<MercadoModel> AdicionarMercadoAsync(MercadoModel mercado);
        Task<MercadoModel> AtualizarMercadoAsync(MercadoModel mercado, int id);
        Task<MercadoModel> BuscarMercadoPorIdAsync(int mercadoId);
        Task<List<MercadoModel>> BuscarTodosAsync();
        Task<List<MercadoModel>> BuscarPorPalavraChaveAsync(string palavraChave);
    }
}
