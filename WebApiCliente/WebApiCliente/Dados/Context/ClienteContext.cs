using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCliente.Domain.Entities;
using WebApiCliente.Domain.Interfaces.Repositoy;

namespace WebApiCliente.Dados.Context
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options)
            : base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }       
    }
    
}
