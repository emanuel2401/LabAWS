using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace NetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Player>> GetJugadores()
        {
            throw new NotImplementedException();
        }

        // GET: api/Jugadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetJugador(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Jugadores
        [HttpPost]
        public async Task<ActionResult<Player>> PostJugador(Player jugador)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Jugadores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJugador(int id, Player jugador)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Jugadores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Player>> DeleteJugador(int id)
        {
            throw new NotImplementedException();
        }
    }
}