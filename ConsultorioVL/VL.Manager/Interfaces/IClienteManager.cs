using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VL.Core.Domain;
using VL.Core.Shared.ModelViews;

namespace VL.Manager.Interfaces
{
    public interface IClienteManager
    {
        Task<Cliente> BuscarClienteAsync(int id);
        Task<IEnumerable<Cliente>> BuscarClientesAsync();
        Task<Cliente> AdicionarClienteAsync(NovoCliente cliente);
        Task<Cliente> AtualizarClienteAsync(AlteraCliente alteraCliente);
        Task RemoverClienteAsync(int id);
    }
}
