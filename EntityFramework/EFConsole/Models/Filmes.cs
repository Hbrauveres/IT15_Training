namespace EFConsole.Models;

public class Filme
{
    public int Id {get; set;} // EF usa Id como chave primaria auto-gerada por convenção
    public string Titulo {get;set;} = null!;
    public int Ano {get;set;}
    public int? Duracao {get;set;}
    public string? Diretor {get;set;}
}