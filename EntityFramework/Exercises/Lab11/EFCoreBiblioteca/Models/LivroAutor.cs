using EFCoreBiblioteca.Models;

public class LivroAutor
{
    // Relacionamento N:1 com Livro
    public int LivroId { get; set; }
    public Livro Livro { get; set; } = null!;
    // Relacionamento N:1 com Autor
    public int AutorId { get; set; }
    public Autor Autor { get; set; } = null!;
}