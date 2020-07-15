using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pesquisa.Models;

namespace pesquisa.Data
{
    public class pesquisaContext : DbContext
    {
        public pesquisaContext (DbContextOptions<pesquisaContext> options)
            : base(options)
        {
        }

        public DbSet<Pergunta> Pergunta { get; set; }
        public DbSet<Resposta> Resposta { get; set; }
    }
}
