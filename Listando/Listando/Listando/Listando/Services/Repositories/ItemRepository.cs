using Listando.Models;
using Listando.Services.Repositories.Interfaces;

namespace Listando.Services.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public Task<ItemModel> AdicionarItemaAsync(ItemModel item)
        {
            throw new NotImplementedException();
        }

        public Task<ItemModel> BuscarItemPorIdAsync(int itemId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemModel>> ListarItensPorListaAsync(ListaModel lista)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveritemAsync(ItemModel item)
        {
            throw new NotImplementedException();
        }
    }
}
