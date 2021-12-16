using DigitalViagem.Models;
using DigitalViagem.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DigitalViagem.Controllers
{
    [Route("Cliente")]
    public class ClienteController : Controller
    {
        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();
            ViewData["clientes"] = dbcontext.Clientes.Where(p => p.Id>0).ToList();
            return View();
        }
    }
}
