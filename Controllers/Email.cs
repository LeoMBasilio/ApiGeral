using ApiGeral.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiGeral.Controllers
{
    [Route("api/Email")]
    [ApiController]
    public class Email : ControllerBase
    {

        private static List<InformacoesEmail> GetInformacoesEmail = new List<InformacoesEmail>();
        private static int id = 1;

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "falta a hash que representa o email cadastrado" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult GetInfos(int id)
        {
            var infos = GetInformacoesEmail.FirstOrDefault(infos => infos.Id == id);
            if (infos == null) return NotFound();
            return Ok(infos);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public CreatedAtActionResult Post([FromBody] InformacoesEmail value)
        {
            value.Id = id++;
            GetInformacoesEmail.Add(value);
            return CreatedAtAction(nameof(GetInfos), new { id = value.Id }, value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public BadRequestResult Put(int id, [FromBody] InformacoesEmail value)
        {
            var infos = GetInformacoesEmail.Find(infos => infos.Id == id);
            if (infos == null) return BadRequest();

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var infos = GetInformacoesEmail.Find(infos => infos.Id == id);
            GetInformacoesEmail.Remove(infos);
        }
    }
}
