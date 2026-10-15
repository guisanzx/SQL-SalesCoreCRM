using SalesCore.Domain.Entities;
using SalesCore.Domain.Repositories;

namespace SalesCore.Application.Services;

public class ContatoService
{
    private readonly IContatoRepository _repository;

    public ContatoService(IContatoRepository repository)
    {
        _repository = repository;
    }

    public Task<IReadOnlyList<Contato>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return _repository.ListarAsync(cancellationToken);
    }
}
