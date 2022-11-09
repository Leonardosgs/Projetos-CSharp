using Listando.Models;
using Listando.Services.Repositories;
using Listando.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Listando.Controllers
{
    [Route("/produtos")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProdutoModel>>> BuscarTodosProdutos()
        {
            List<ProdutoModel> usuarios = await _produtoRepository.BuscarTodosAsync();
            if (usuarios.Count == 0)
            {
                return NotFound(null);
            }
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoModel>> BuscarProdutoPorId(int id)
        {
            ProdutoModel p = await _produtoRepository.BuscarProdutoPorIdAsync(id);
            if (p == null)
            {
                return NotFound(null);
            }
            return Ok(p);
        }

        [HttpGet("/produtos/nome/{nome}")]
        public async Task<ActionResult<List<ProdutoModel>>> BuscarPorNome(string nome)
        {
            List<ProdutoModel> lista =  await _produtoRepository.BuscarProdutoPorPalavraChaveAsync(nome);
            if (lista.Count == 0)
            {
                return NotFound(null);
            }
            return Ok(lista);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> AdicionarProduto([FromBody] ProdutoModel produto)
        {

            ProdutoModel p = await _produtoRepository.AdicionarProdutoAsync(produto);
            return Ok(p);
        }

        [HttpPut]
        public async Task<ActionResult<ProdutoModel>> AtualizarProduto([FromBody] ProdutoModel produto)
        {
            return Ok(await _produtoRepository.AtualizarProdutoAsync(produto));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> RemoverProduto(int id)
        {
            return Ok(await _produtoRepository.RemoverProdutoAsync(id));
        }
    }
}
