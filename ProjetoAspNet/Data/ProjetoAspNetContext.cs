using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoAspNet.Models;

namespace ProjetoAspNet.Data
{
    public class ProjetoAspNetContext : DbContext
    {
        public ProjetoAspNetContext (DbContextOptions<ProjetoAspNetContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoAspNet.Models.Departamento> Departamento { get; set; }
    }
}
