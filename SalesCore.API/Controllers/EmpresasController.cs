using Microsoft.AspNetCore.Mvc;
using SalesCore.Application.Services;
using SalesCore.Domain.Entities;

namespace SalesCore.API.Controllers;

[ApiController]
[Route("api/empresas")]
public class EmpresasController : ControllerBase
{
    private readonly EmpresaService _service;

    public EmpresasController(EmpresaService service)
    {
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<Empresa>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<Empresa>>> Get(CancellationToken cancellationToken)
    {
        var items = await _service.ListarAsync(cancellationToken);
        return Ok(items);
    }
}
