using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCliente.Domain.Entities;
using WebApiCliente.Domain.Interfaces.Repositoy;
using WebApiCliente.Domain.Interfaces.Services;

namespace WebApiCliente.Services
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _repository;
        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task<Cliente> Add(Cliente cliente)
        {
            return await _repository.AddClienteAsync(cliente);
        }

        public async Task<string> Delete(Guid id)
        {
            return string.Format("Exclusão realizada com {0}",
                                 await _repository.DeleteClienteAsync(id) ? "Sucesso."
                                 : "Falha. Cliente não encontrado.");
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _repository.GetAllClienteAsync();            
        }

        public async Task<Cliente> GetById(Guid id)
        {
            return await _repository.GetClienteIdAsync(id);
        }
               

        public async Task<string> Update(Cliente cliente)
        {
            string msg = "Alteração realizada com {0}";           

            return string.Format( msg ,  await _repository.UpdateClienteAsync(cliente) ? "Sucesso."
                                         : "Falha. Cliente não encontrado.");

        }
    }
}
