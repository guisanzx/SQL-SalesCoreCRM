using SalesCore.Domain.Entities;
using SalesCore.Domain.Repositories;

namespace SalesCore.Application.Services;

public class UsuarioService
{
    private readonly IUsuarioRepository _repository;

    public UsuarioService(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public Task<IReadOnlyList<Usuario>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return _repository.ListarAsync(cancellationToken);
    }
}
