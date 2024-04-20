using System.Net;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Models;
namespace api.Controllers
{
    [Controller]
    [Route("pessoa")]
    public class PessoaController : ControllerBase
    {
        private  DataContext dc;

        public   PessoaController(DataContext context)
        {
            this.dc = context;
        }


            [HttpPost("api")]
        public async Task <ActionResult> Cadastrar([FromBody] Pessoa p)
        {
            dc.pessoa.Add(p);
            await dc.SaveChangesAsync();
            return Created("Objeto pessoa", p);
        }

        [HttpGet("api")]
        public async Task <ActionResult> Listar ()
        {
          var dados = await  dc.pessoa.ToListAsync();
          return Ok(dados);
        }

        [HttpGet("oi")]
        public string oi()
        {
            return "Hello world";
        }
    }
}