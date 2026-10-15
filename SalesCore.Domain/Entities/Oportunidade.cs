namespace SalesCore.Domain.Entities;

public class Oportunidade
{
    public int idOportunidade { get; set; }
    public string titulo { get; set; } = string.Empty;
    public string? descricao { get; set; }
    public string? valorEstimado { get; set; }
    public DateOnly dtAbertura { get; set; }
    public DateOnly? dtPrevisaoFechamento { get; set; }
    public string cnpj { get; set; } = string.Empty;
    public int idEtapa { get; set; }
    public int idUsuario { get; set; }
}
