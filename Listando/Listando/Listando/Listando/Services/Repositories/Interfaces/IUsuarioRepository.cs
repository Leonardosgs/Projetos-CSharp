using Listando.Models;
using System.Runtime.CompilerServices;

namespace Listando.Services.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<UsuarioModel> AdicionarUsuarioAsync(UsuarioModel usuario);
        Task<UsuarioModel> AtualizarUsuarioAsync(UsuarioModel usuario);
        Task<bool> RemoverUsuarioAsync(int userId);
        Task<UsuarioModel> BuscarUsuarioPorIdAsync(int usuarioId);
        Task<List<UsuarioModel>> BuscarTodosUsuariosAsync();
        Task<List<UsuarioModel>> BuscarUsuarioPorPalavraChaveAsync(string palavraChave);
        Task<UsuarioModel> BuscarUsuarioPorEmailAsync(string email);
    }
}
