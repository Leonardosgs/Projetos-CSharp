using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VL.Core.Domain;

namespace VL.Manager.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente> BuscarClienteAsync(int id);
        Task<IEnumerable<Cliente>> BuscarClientesAsync();
        Task<Cliente> AdicionarClienteAsync(Cliente cliente);
        Task<Cliente> AtualizarClienteAsync(Cliente cliente);
        Task RemoverClienteAync(int id);

    }
}
