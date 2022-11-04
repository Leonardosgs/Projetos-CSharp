using Listando.Data.Map;
using Listando.Models;
using Microsoft.EntityFrameworkCore;

namespace Listando.Data
{
    public class SistemaDbContext : DbContext
    {
        public SistemaDbContext(DbContextOptions<SistemaDbContext> options) 
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<MarcaModel> Marcas { get; set; }
        public DbSet<MercadoModel> Mercados { get; set; }
        public DbSet<ListaModel> Listas { get; set; }
        public DbSet<ItemModel> Itens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
