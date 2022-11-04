using Listando.Models;

namespace Listando.Services.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        Task<ProdutoModel> AdicionarProdutoAsync(ProdutoModel produto);
        Task<ProdutoModel> AtualizarProdutoAsync(ProdutoModel produto);
        Task<bool> RemoverProdutoAsync(ProdutoModel produto);
        Task<ProdutoModel> BuscarProdutoPorIdAsync(int idProduto);
        Task<List<ProdutoModel>> BuscarProdutoPorPalavraChaveAsync(string palavraChave);
        Task<List<ProdutoModel>> BuscarTodosAsync();

    }
}
