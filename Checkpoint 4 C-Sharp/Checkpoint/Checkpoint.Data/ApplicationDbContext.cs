using Checkpoint.Model;
using Microsoft.EntityFrameworkCore;

namespace Checkpoint.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<RM99405_Fornecedor> Fornecedores { get; set; }
        public DbSet<RM99405_Produto> Produtos { get; set; }
        public DbSet<RM99405_Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RM99405_Fornecedor>().ToTable("RM99405_Fornecedor");
            modelBuilder.Entity<RM99405_Produto>().ToTable("RM99405_Produto");
            modelBuilder.Entity<RM99405_Pedido>().ToTable("RM99405_Pedido");
        }
    }
}