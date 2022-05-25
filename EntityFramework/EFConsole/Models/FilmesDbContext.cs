using Microsoft.EntityFrameworkCore;

namespace EFConsole.Models;

public class FilmesDbContext : DbContext
{
    public DbSet<Filme> Filmes {get;set;} = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Filme>(
            entity =>
            {
                entity.Property(e => e.Titulo).HasMaxLength(50);
            }
        );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // NÃO DEVE COLOCAR STRING DE CONEXÃO FIXA NO CODIGO!!!!
        optionsBuilder.UseSqlServer(@"Data Source=---------;Initial Catalog=IT15_BD_Filmes;Integrated Security=True"); // @ -> string literal
        optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
    }
}