using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ModuloApi.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) // Construtor que recebe as opções de configuração do DbContext. Funciona como uma injeção de dependência. Serve para configurar a conexão com o banco de dados.
        {
        }

        public DbSet<Entities.Contato> Contatos { get; set; } // Representa a tabela "Contatos" no banco de dados. Cada instância de Contato corresponde a uma linha na tabela.
    }
}