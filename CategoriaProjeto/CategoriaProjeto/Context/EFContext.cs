using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CategoriaProjeto.Models;

namespace CategoriaProjeto.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp Net MVC CS") { }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }

    }
}