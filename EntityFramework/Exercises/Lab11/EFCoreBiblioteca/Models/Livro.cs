namespace EFCoreBiblioteca.Models;

public class Livro
{
    public int LivroId { get; set; }
    public string Titulo { get; set; } = null!;
    // Relacionamento 1:N com Emprestimo
    public List<Emprestimo>? Emprestimos { get; set; }
    
    // Relacionamento N:N com Autor
    public List<LivroAutor> LivrosAutores { get; set; } = null!;
    public ICollection<Autor> Autores { get; set; } = null!;

}