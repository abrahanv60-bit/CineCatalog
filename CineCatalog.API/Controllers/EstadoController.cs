using CineCatalog.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineCatalog.API.Controllers;

[ApiController]
[Route("api/estado")]
public class EstadoController(AppDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var postgresConectado = await db.Database.CanConnectAsync(cancellationToken);

        var respuesta = new
        {
            api = "funcionando",
            postgresql = postgresConectado ? "conectado" : "sin conexion",
            fechaUtc = DateTime.UtcNow
        };

        return postgresConectado ? Ok(respuesta) : StatusCode(503, respuesta);
    }
}
