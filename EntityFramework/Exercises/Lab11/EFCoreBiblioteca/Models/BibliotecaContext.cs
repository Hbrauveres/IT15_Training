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
}