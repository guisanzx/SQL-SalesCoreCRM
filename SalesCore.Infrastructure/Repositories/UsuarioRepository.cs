using Microsoft.EntityFrameworkCore;
using SalesCore.Domain.Entities;
using SalesCore.Domain.Repositories;
using SalesCore.Infrastructure.Data;

namespace SalesCore.Infrastructure.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly SalesCoreDbContext _context;

    public UsuarioRepository(SalesCoreDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Usuario>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Usuarios
            .AsNoTracking()
            .OrderBy(entity => entity.idUsuario)
            .ToListAsync(cancellationToken);
    }
}
