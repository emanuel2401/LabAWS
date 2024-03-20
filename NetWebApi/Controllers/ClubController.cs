using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace NetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Club>> GetEquipos()
        {
            throw new NotImplementedException();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Club>> GetEquipoById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult<Club>> PostEquipo(Club club)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipo(int id, Club equipo)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Club>> DeleteEquipo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
