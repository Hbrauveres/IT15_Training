using Microsoft.EntityFrameworkCore;
namespace EFCoreBiblioteca.Models;


public class BibliotecaContext : DbContext
{
    public BibliotecaContext()
    {
    }

    public BibliotecaContext(DbContextOptions<BibliotecaContext> options) 
    : base(options)
    {
    }

    public DbSet<Livro> Livros { get; set; } = null!;
    public DbSet<Autor> Autores { get; set; } = null!;
    public DbSet<Emprestimo> Emprestimos { get; set; } = null!;

    public DbSet<LivroAutor> LivroAutor { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>(entity =>
        {
            entity.HasKey(e => e.LivroId);
        });

        modelBuilder.Entity<Autor>(entity => {
            entity.HasKey(e => e.AutorId);
        });

        modelBuilder.Entity<Emprestimo>(entity => {
            entity.HasKey(e => e.EmprestimoId);
        }); 

        modelBuilder.Entity<Livro>()
            .HasMany(e => e.Autores)
            .WithMany(e => e.Livros)
            .UsingEntity<LivroAutor>();

        modelBuilder.Entity<LivroAutor>()
            .HasKey(e => new { e.LivroId, e.AutorId });
    }
}