using System.ComponentModel.DataAnnotations;

public class Pessoa
{
    // [Required(AllowEmptyStrings = true)]
    public string Nome {get; set;} = null!;

    [EmailAddress(ErrorMessage = "Deve ser um formato valido de {0}")] // Garante que email esteja de acordo com padrão de email
    public string? Email {get; set;} // Nullable -> email não é obrigatorio (pode ser null) 

    [Range(0,150, ErrorMessage = "{0} deve estar entre {1} e {2}")]
    public int Idade {get; set;}
}