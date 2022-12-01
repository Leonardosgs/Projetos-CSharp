using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VL.Core.Domain;
using VL.Core.Shared.ModelViews;
using VL.Manager.Interfaces;
using VL.Manager.Validator;

namespace VL.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteManager manager;

        public ClientesController(IClienteManager manager)
        {
            this.manager = manager;
        }
        /// <summary>
        /// Retorna Todos os clientes cadastrados no banco de dados
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodos()
        {
            return Ok(await manager.BuscarClientesAsync());
        }

        /// <summary>
        /// Retorna cliente com id passado no paramentro
        /// </summary>
        /// <param name="id" example="10">Id do cliente</param>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCliente(int id)
        {
            return Ok(await manager.BuscarClienteAsync(id));
        }

        /// <summary>
        /// Cadastra o cliente no banco de dados
        /// </summary>
        /// <param name="novoCliente"></param>
        [HttpPost]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AdiconarCliente([FromBody] NovoCliente novoCliente)
        {
            var c = await manager.AdicionarClienteAsync(novoCliente);
            return CreatedAtAction(nameof(BuscarCliente), new { id = c.Id}, c);
        }

        /// <summary>
        /// Altera propriedades do cliente informado pelo id
        /// </summary>
        /// <param name="alteraCliente"></param>
        [HttpPut]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AtualizarCliente([FromBody] AlteraCliente alteraCliente)
        {
            var cli = await manager.AtualizarClienteAsync(alteraCliente);
            if (cli == null)
            {
                return NotFound();
            }
            return Ok(cli);
        }

        /// <summary>
        /// Deleta o cliente do banco de dados enviando como parametro seu id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RemoverCliente(int id)
        {
            await manager.RemoverClienteAsync(id);
            return NoContent();
        }
    }
}
