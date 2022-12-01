using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using VL.Core.Domain;
using VL.Core.Shared.ModelViews;
using VL.Manager.Interfaces;

namespace VL.Manager.Implementation
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepository clienteRpository;
        private readonly IMapper mapper;
        public ClienteManager(IClienteRepository clienteRepository, IMapper mapper)
        {
            this.clienteRpository = clienteRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Cliente>> BuscarClientesAsync()
        {
            return await clienteRpository.BuscarClientesAsync();
        }

        public async Task<Cliente> BuscarClienteAsync(int id)
        {
            return await clienteRpository.BuscarClienteAsync(id);
        }

        public async Task<Cliente> AdicionarClienteAsync(NovoCliente novoCliente)
        {
            var cliente = mapper.Map<Cliente>(novoCliente);
            return await clienteRpository.AdicionarClienteAsync(cliente);
        }

        public async Task<Cliente> AtualizarClienteAsync(AlteraCliente alteraCliente)
        {
            var cliente = mapper.Map<Cliente>(alteraCliente);
            return await clienteRpository.AtualizarClienteAsync(cliente);
        }

        public async Task RemoverClienteAsync(int id)
        {
            await clienteRpository.RemoverClienteAync(id);
        }
    }
}
