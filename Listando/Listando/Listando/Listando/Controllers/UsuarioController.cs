using Listando.Models;
using Listando.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Listando.Controllers
{
    [Route("/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios()
        {
            List<UsuarioModel> usuarios = await _usuarioRepository.BuscarTodosUsuariosAsync();
            if (usuarios.Count == 0)
            {
                return NotFound(null);
            }
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorId(int id)
        {
            UsuarioModel usuario = await _usuarioRepository.BuscarUsuarioPorIdAsync(id);
            if (usuario == null)
            {
                return NotFound(null);
            }
            return Ok(usuario);
        }

        [HttpGet("/usuarios/email/{email}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorEmail(string email)
        {
            UsuarioModel usuario = await _usuarioRepository.BuscarUsuarioPorEmailAsync(email);
            if (usuario == null)
            {
                return NotFound(null);
            }
            return Ok(usuario);
        }

        [HttpGet("/usuarios/nome/{nome}")]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarPorPalavraChave(string nome)
        {
            List<UsuarioModel> usuarios = await _usuarioRepository.BuscarUsuarioPorPalavraChaveAsync(nome);
            if (usuarios.Count == 0)
            {
                return NotFound(null);
            }
            return Ok(usuarios);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> CadastrarUsuario([FromBody] UsuarioModel usuario)
        {
            UsuarioModel u = await _usuarioRepository.AdicionarUsuarioAsync(usuario);
            return Ok(u);
        }

        [HttpPut]
        public async Task<ActionResult<UsuarioModel>> AtualizarUsuario([FromBody] UsuarioModel usuario)
        {
            UsuarioModel u = await _usuarioRepository.AtualizarUsuarioAsync(usuario);
            return Ok(u);
        }
        
        [HttpDelete]
        public async Task<ActionResult<UsuarioModel>> RemoverUsuario([FromBody] UsuarioModel usuario)
        {
            bool apagado = await _usuarioRepository.RemoverUsuarioAsync(usuario.Id);
            return Ok(apagado);
        }

    }
}
