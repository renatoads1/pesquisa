using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pesquisa.Models;
using pesquisa.Models.ViewModels;

namespace pesquisa.Data
{
    public class roboshomologacaoContext : DbContext
    {
        public roboshomologacaoContext(DbContextOptions<roboshomologacaoContext> options)
            : base(options)
        {

        }

        public DbSet<Pbhxmlprestlistfile> Pbhxmlprestlistfile { get; set; }

        public DbSet<pesquisa.Models.ViewModels.pbhxmlprestlog> pbhxmlprestlog { get; set; }

    }
}
