using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCliente.Domain.Entities;

namespace WebApiCliente.Domain.Interfaces.Repositoy
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetAllClienteAsync();
        Task<Cliente> GetClienteIdAsync(Guid id);
        Task<Cliente> AddClienteAsync(Cliente cliente);
        Task<bool> UpdateClienteAsync(Cliente cliente);
        Task<bool> DeleteClienteAsync(Guid id);
    }
}
