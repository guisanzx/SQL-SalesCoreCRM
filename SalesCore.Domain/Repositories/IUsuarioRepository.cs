using SalesCore.Domain.Entities;

namespace SalesCore.Domain.Repositories;

public interface IUsuarioRepository
{
    Task<IReadOnlyList<Usuario>> ListarAsync(CancellationToken cancellationToken = default);
}
