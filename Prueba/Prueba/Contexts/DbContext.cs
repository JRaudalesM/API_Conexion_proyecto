using Microsoft.EntityFrameworkCore;
using Prueba.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Contexts
{
    public class DBContxt:DbContext
    {
        public DBContxt(DbContextOptions<DBContxt> options) : base(options)
        {
        }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

    }

  
}
