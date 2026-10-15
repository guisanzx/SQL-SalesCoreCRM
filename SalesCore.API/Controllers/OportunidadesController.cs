using Microsoft.AspNetCore.Mvc;
using SalesCore.Application.Services;
using SalesCore.Domain.Entities;

namespace SalesCore.API.Controllers;

[ApiController]
[Route("api/oportunidades")]
public class OportunidadesController : ControllerBase
{
    private readonly OportunidadeService _service;

    public OportunidadesController(OportunidadeService service)
    {
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<Oportunidade>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<Oportunidade>>> Get(CancellationToken cancellationToken)
    {
        var items = await _service.ListarAsync(cancellationToken);
        return Ok(items);
    }
}
