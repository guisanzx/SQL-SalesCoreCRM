using SalesCore.Domain.Entities;
using SalesCore.Domain.Repositories;

namespace SalesCore.Application.Services;

public class EmpresaService
{
    private readonly IEmpresaRepository _repository;

    public EmpresaService(IEmpresaRepository repository)
    {
        _repository = repository;
    }

    public Task<IReadOnlyList<Empresa>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return _repository.ListarAsync(cancellationToken);
    }
}
