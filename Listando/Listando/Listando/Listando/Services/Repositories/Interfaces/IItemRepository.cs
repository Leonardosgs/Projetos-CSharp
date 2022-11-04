using Listando.Models;

namespace Listando.Services.Repositories.Interfaces
{
    public interface IItemRepository
    {
        Task<ItemModel> AdicionarItemaAsync(ItemModel item);
        Task<ItemModel> BuscarItemPorIdAsync(int itemId);
        Task<bool> RemoveritemAsync(ItemModel item);
        Task<List<ItemModel>> ListarItensPorListaAsync(ListaModel lista);
    }
}
