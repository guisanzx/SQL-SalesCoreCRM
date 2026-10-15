namespace SalesCore.Domain.Entities;

public class Contato
{
    public int idContato { get; set; }
    public string nome { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public string? telefone { get; set; }
    public string? cargo { get; set; }
    public bool ativo { get; set; }
    public string cnpj { get; set; } = string.Empty;
}
