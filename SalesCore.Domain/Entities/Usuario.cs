namespace SalesCore.Domain.Entities;

public class Usuario
{
    public int idUsuario { get; set; }
    public string nome { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public string? cargo { get; set; }
    public bool ativo { get; set; }
}
