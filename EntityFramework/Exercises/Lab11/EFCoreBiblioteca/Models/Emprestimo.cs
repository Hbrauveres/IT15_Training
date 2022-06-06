namespace EFCoreBiblioteca.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public bool Devolvido { get; set; }

        // Relacionamento N:1 com Livro
        public int LivroId { get; set; }
        public Livro Livro { get; set; } = null!;
    }
}