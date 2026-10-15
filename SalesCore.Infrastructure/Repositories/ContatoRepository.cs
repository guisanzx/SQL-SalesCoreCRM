using Microsoft.EntityFrameworkCore;
using SalesCore.Domain.Entities;
using SalesCore.Domain.Repositories;
using SalesCore.Infrastructure.Data;

namespace SalesCore.Infrastructure.Repositories;

public class ContatoRepository : IContatoRepository
{
    private readonly SalesCoreDbContext _context;

    public ContatoRepository(SalesCoreDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Contato>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Contatos
            .AsNoTracking()
            .OrderBy(entity => entity.idContato)
            .ToListAsync(cancellationToken);
    }
}
