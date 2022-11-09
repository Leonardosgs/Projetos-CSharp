using Listando.Data;
using Listando.Models;
using Listando.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;

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
            return await _dbContext.Produtos.Include(p => p.Marca).FirstOrDefaultAsync(p => p.Id == idProduto);
        }

        public async Task<List<ProdutoModel>> BuscarProdutoPorPalavraChaveAsync(string palavraChave)
        {
            return await _dbContext.Produtos.Where(p => p.Nome.StartsWith(palavraChave, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();
        }

        public async Task<List<ProdutoModel>> BuscarTodosAsync()
        {
            List<ProdutoModel> lista = await _dbContext.Produtos.Include(p => p.Marca).ToListAsync();
            return lista;
        }

        public async Task<ProdutoModel> AdicionarProdutoAsync(ProdutoModel produto)
        {
            MarcaModel m = await _dbContext.Marcas.FirstOrDefaultAsync(m => m.Id == produto.Id);
            if (m == null)
            {
                produto.Marca = _dbContext.Marcas.Add(produto.Marca).Entity;
            }
            await _dbContext.AddAsync(produto);
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

            p.Nome = produto.Nome;
            p.UnidadeVolume = produto.UnidadeVolume;
            p.Volume = produto.Volume;
            p.Marca = produto.Marca;

            _dbContext.Produtos.Update(p);
            await _dbContext.SaveChangesAsync();
            return p;
        }

        public async Task<bool> RemoverProdutoAsync(int id)
        {
            ProdutoModel p = await BuscarProdutoPorIdAsync(id);

            if (p == null)
            {
                throw new Exception($"Produto para o Id: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Produtos.Remove(p);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
