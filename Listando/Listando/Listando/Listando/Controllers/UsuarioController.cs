using Listando.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Listando.Controllers
{
    [Route("/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}
