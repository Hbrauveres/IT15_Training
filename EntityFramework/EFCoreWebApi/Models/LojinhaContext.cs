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
}