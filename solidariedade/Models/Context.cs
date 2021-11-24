using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solidariedade.Models;

namespace solidariedade.Models
{
    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Ocorrencia> Ocorrencias { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
        }

    }
}
