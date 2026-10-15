using SalesCore.Domain.Entities;
using SalesCore.Domain.Repositories;

namespace SalesCore.Application.Services;

public class OportunidadeService
{
    private readonly IOportunidadeRepository _repository;

    public OportunidadeService(IOportunidadeRepository repository)
    {
        _repository = repository;
    }

    public Task<IReadOnlyList<Oportunidade>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return _repository.ListarAsync(cancellationToken);
    }
}
