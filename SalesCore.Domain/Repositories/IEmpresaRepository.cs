using SalesCore.Domain.Entities;

namespace SalesCore.Domain.Repositories;

public interface IEmpresaRepository
{
    Task<IReadOnlyList<Empresa>> ListarAsync(CancellationToken cancellationToken = default);
}
