using Listando.Models;

namespace Listando.Services.Repositories.Interfaces
{
    public interface IListaRepository
    {
        Task<ListaModel> AdiconarListaAsync(ListaModel lista);
        Task<ListaModel> AtualizarListaAsync(ListaModel lista, int Id); 
        Task<ListaModel> RemoverListaAsync(ListaModel lista);
        Task<List<ListaModel>> BudcarTodasAsync();
        Task<List<ListaModel>> BuscarListasPorUsuarioAsync(UsuarioModel usuario);
    }
}
