using Microsoft.AspNetCore.Mvc;
using SalesCore.Application.Services;
using SalesCore.Domain.Entities;

namespace SalesCore.API.Controllers;

[ApiController]
[Route("api/contatos")]
public class ContatosController : ControllerBase
{
    private readonly ContatoService _service;

    public ContatosController(ContatoService service)
    {
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<Contato>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<Contato>>> Get(CancellationToken cancellationToken)
    {
        var items = await _service.ListarAsync(cancellationToken);
        return Ok(items);
    }
}
