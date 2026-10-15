using SalesCore.Domain.Entities;

namespace SalesCore.Domain.Repositories;

public interface IOportunidadeRepository
{
    Task<IReadOnlyList<Oportunidade>> ListarAsync(CancellationToken cancellationToken = default);
}
