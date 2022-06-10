public class LivroNaoEncontradoException : Exception
{
    public LivroNaoEncontradoException(int id) 
    : base($"Não foi possivel localizar o livro com id {id}")
    {
    }
}