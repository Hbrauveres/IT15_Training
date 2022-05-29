public class CEP
{
    public string? Erro {get;set;}
    public string? Cep {get;set;}
    public string? Logradouro {get;set;}
    public string? Complemento {get;set;}
    public string? Bairro {get;set;}
    public string? Localidade {get;set;}
    public string? Uf {get;set;}

    public override string ToString()
    {
        return $"{Cep}, {Logradouro}, {Complemento}, {Bairro}, {Localidade}, {Uf}";
    }
}