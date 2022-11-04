using Listando.Models;
using Listando.Services.Repositories.Interfaces;

namespace Listando.Services.Repositories
{
    public class ListaRepository : IListaRepository
    {
        public Task<ListaModel> AdiconarListaAsync(ListaModel lista)
        {
            throw new NotImplementedException();
        }

        public Task<ListaModel> AtualizarListaAsync(ListaModel lista, int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListaModel>> BudcarTodasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ListaModel>> BuscarListasPorUsuarioAsync(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<ListaModel> RemoverListaAsync(ListaModel lista)
        {
            throw new NotImplementedException();
        }
    }
}
