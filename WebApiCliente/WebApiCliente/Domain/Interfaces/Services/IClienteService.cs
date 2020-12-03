using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCliente.Domain.Entities;

namespace WebApiCliente.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetAll();
        Task<Cliente> GetById(Guid id);
        Task<string> Delete(Guid id);
        Task<Cliente> Add(Cliente cliente);
        Task<string> Update(Cliente cliente);

    }
}
