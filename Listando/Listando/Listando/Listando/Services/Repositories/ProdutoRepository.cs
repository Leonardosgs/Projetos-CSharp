using Listando.Data;
using Listando.Models;
using Listando.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Listando.Services.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly SistemaDbContext _dbContext;
        public ProdutoRepository(SistemaDbContext sistemaDbContext)
        {
            _dbContext = sistemaDbContext;
        }

        public async Task<ProdutoModel> BuscarProdutoPorIdAsync(int idProduto)
        {
            return await _dbContext.Produtos.FirstOrDefaultAsync(p => p.Id == idProduto);
        }

        public async Task<List<ProdutoModel>> BuscarProdutoPorPalavraChaveAsync(string palavraChave)
        {
            return await _dbContext.Produtos.Where(p => p.Nome.StartsWith(palavraChave, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();
        }

        public async Task<List<ProdutoModel>> BuscarTodosAsync()
        {
            return await _dbContext.Produtos.ToListAsync();
        }

        public async Task<ProdutoModel> AdicionarProdutoAsync(ProdutoModel produto)
        {
            await _dbContext.Produtos.AddAsync(produto);
            await _dbContext.SaveChangesAsync();
            return produto;
        }

        public async Task<ProdutoModel> AtualizarProdutoAsync(ProdutoModel produto)
        {
            ProdutoModel p = await BuscarProdutoPorIdAsync(produto.Id);

            if (p == null)
            {
                throw new Exception($"Produto para o Id: {produto.Id} não foi encontrado no banco de dados.");
            }

            _dbContext.Produtos.Update(produto);
            await _dbContext.SaveChangesAsync();
            return p;
        }

        public async Task<bool> RemoverProdutoAsync(ProdutoModel produto)
        {
            ProdutoModel p = await BuscarProdutoPorIdAsync(produto.Id);

            if (p == null)
            {
                throw new Exception($"Produto para o Id: {produto.Id} não foi encontrado no banco de dados.");
            }

            _dbContext.Produtos.Remove(p);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
