using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCliente.Dados.Context;
using WebApiCliente.Domain.Entities;
using WebApiCliente.Domain.Interfaces.Repositoy;

namespace WebApiCliente.Dados.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteContext _context;
        public ClienteRepository(ClienteContext context)
        {
            _context = context;
        }
        public async Task<Cliente> AddClienteAsync(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<bool> DeleteClienteAsync(Guid id)
        {
            var cliente = await GetClienteIdAsync(id);
            if (cliente != null)
            {
                _context.Cliente.Remove(cliente);
                return await _context.SaveChangesAsync() > 0;
            }
            else
                return false;
        }

        public async Task<List<Cliente>> GetAllClienteAsync()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<Cliente> GetClienteIdAsync(Guid id)
        {
            return await _context.Cliente.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateClienteAsync(Cliente cliente)
        {
            try
            {
                _context.Cliente.Update(cliente);

                return await _context.SaveChangesAsync() > 0;
            }
            catch
            {
                return false;
            }                
        }
    }
}
