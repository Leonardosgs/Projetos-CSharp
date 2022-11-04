using Listando.Models;

namespace Listando.Services.Repositories.Interfaces
{
    public interface IMarcaRepository
    {
        Task<MarcaModel> AdicionarMarcaAsync(MarcaModel marca);
        Task<MarcaModel> AtualizarMarcaAsync(MarcaModel marca);
        Task<MarcaModel> BuscarMarcaPorIdAsync(int marcaId);
        Task<bool> RemoverMarcaAsync(MarcaModel marca);
        Task<List<MarcaModel>> BuscarPorPalavraChaveAsync(string palavraChave);
        Task<List<MarcaModel>> BuscarTodasAsync();
    }
}
