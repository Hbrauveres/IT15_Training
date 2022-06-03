namespace EFCoreWebApi.Services;
    
public class ProdutoNaoEncontradoException : Exception
{
    public ProdutoNaoEncontradoException(int id) : base($"Produto id={id} não encontrado.")
    {
    }
}