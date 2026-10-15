namespace SalesCore.Domain.Entities;

public class Empresa
{
    public string cnpj { get; set; } = string.Empty;
    public string razaoSocial { get; set; } = string.Empty;
    public string nomeFantasia { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public string? telefone { get; set; }
    public DateTime dataCadastro { get; set; }
    public bool ativo { get; set; }
}
