using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VL.Core.Domain;
using VL.Data.Context;
using VL.Manager.Interfaces;

namespace VL.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly VlContext context;

        public ClienteRepository(VlContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Cliente>> BuscarClientesAsync()
        {
            return await context.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> BuscarClienteAsync(int id)
        {
            return await context.Clientes.FindAsync(id);
        }

        public async Task<Cliente> AdicionarClienteAsync(Cliente cliente)
        {
            await context.Clientes.AddAsync(cliente);
            await context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> AtualizarClienteAsync(Cliente cliente)
        {
            Cliente c = await context.Clientes.FindAsync(cliente.Id );

            if (c == null)
            {
                return null;
            }

            context.Entry(c).CurrentValues.SetValues(cliente);
            await context.SaveChangesAsync();
            return c;
        }

        public async Task RemoverClienteAync(int id)
        {
            var cliente = await context.Clientes.FindAsync(id);
            context.Clientes.Remove(cliente);
            await context.SaveChangesAsync();
        }
    }
}
