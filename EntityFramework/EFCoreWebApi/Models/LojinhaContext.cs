// ESSA CLASSE SERIA MELHOR POSICIONADA EM UMA PASTA SERVICE!
using Microsoft.EntityFrameworkCore;
namespace EFCoreWebApi.Models;

public class LojinhaContext : DbContext
{
    public LojinhaContext()
    {
    }

    // configurado no program.cs
    public LojinhaContext(DbContextOptions<LojinhaContext> options) : base(options) 
    {
    }

    public DbSet<Produto> Produtos {get;set;} = null!;
    public DbSet<Cliente> Clientes {get;set;} = null!;
    public DbSet<Pedido> Pedidos {get;set;} = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Responsavel por construir as configurações 
        // do mapeamento da entidade PRODUTO.
        modelBuilder.Entity<Produto>(entityBuilder => { 
            entityBuilder.Property(e => e.Nome)
                .HasMaxLength(30);
            entityBuilder.Property(e => e.Descricao)
                .HasMaxLength(200);
        });
        modelBuilder.Entity<Cliente>(entityBuilder => {
            entityBuilder.Property(e => e.Nome)
                .HasMaxLength(30);
            entityBuilder.Property(e => e.Email)
                .HasMaxLength(50);
        });
        modelBuilder.Entity<Pedido>()
            .HasMany(e => e.Produtos)
            .WithMany(e => e.Pedidos)
            .UsingEntity<ItemPedido>();
    }
}