using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace NetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Match>> GetPartidos()
        {
            throw new NotImplementedException(); ;
        }

        // GET: api/Partidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Match>> GetPartido(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Partidos
        [HttpPost]
        public async Task<ActionResult<Match>> PostPartido(Match partido)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Partidos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartido(int id, Match partido)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Partidos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Match>> DeletePartido(int id)
        {
            throw new NotImplementedException();
        }
    }
}
