using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace api.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class PessoaController
    {
        [HttpGet("oi")]
        public string oi()
        {
            return "Hello world";
        }
    }
}