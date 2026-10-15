using SalesCore.Domain.Entities;

namespace SalesCore.Domain.Repositories;

public interface IContatoRepository
{
    Task<IReadOnlyList<Contato>> ListarAsync(CancellationToken cancellationToken = default);
}
