using EFCoreBiblioteca.Models;

public class AutorLivrosDTO
{
    public int AutorId { get; set; }
    public IEnumerable<Livro> Livros { get; set; } = null!;
}