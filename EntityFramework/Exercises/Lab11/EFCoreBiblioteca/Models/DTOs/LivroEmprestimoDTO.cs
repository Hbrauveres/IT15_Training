using EFCoreBiblioteca.Models;

public class LivroEmprestimoDTO
{
    public int LivroId { get; set; }
    public string Titulo { get; set; } = null!;
    public bool Disponivel { get; set; }
    public DateTime? DataEntrega { get; set; }
}