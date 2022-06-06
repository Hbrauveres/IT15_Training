using EFCoreBiblioteca.Models;

public class Autor
{
    public int AutorId { get; set; }
    public string Nome { get; set; } = null!;
    public string UltimoNome { get; set; } = null!;
    // Relacionamento N:N com Livro
    public List<LivroAutor> LivrosAutores { get; set; } = null!;
    public ICollection<Livro> Livros { get; set; } = null!;
}