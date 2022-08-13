using Aprendendo_API.NovaPasta3;
using Microsoft.EntityFrameworkCore;

namespace Aprendendo_API.Context
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions<AppContext> options ) : base ( options )
        {}
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }

}
