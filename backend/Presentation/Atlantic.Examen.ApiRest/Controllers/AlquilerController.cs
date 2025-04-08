using Atlantic.Examen.Application.Commands;
using Atlantic.Examen.Models.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Atlantic.Examen.ApiRest.Controllers
{
    [Route("alquiler")]
    [ApiController]
    public class AlquilerController (IMediator mediator): Controller
    {
        [HttpPost("")]
        public async Task<IActionResult> Registrar([FromBody] RegistrarAlquilerRq model)
        {
            await mediator.Send(new RegistrarAlquilerCommand { Data = model });
            return Ok();
        }
    }
}
