using DigitalViagem.Models;
using DigitalViagem.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using DigitalViagem.Enum;

namespace DigitalViagem.Controllers
{
    [Route("Cliente")]
    public class ClienteController : Controller
    {
        //Método GET
        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["clientes"] = dbcontext.Clientes.Where(p => p.Id>0).ToList();
            return View();
        }

        //Método POST
        [HttpPost]
        [Route("Incluir")]
        public IActionResult Incluir(Cliente cliente)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(cliente);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}
