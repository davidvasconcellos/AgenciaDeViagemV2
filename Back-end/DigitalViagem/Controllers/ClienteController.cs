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
        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();
            //Teste
            var cliente = new Cliente();

            cliente.Nome = "David";
            cliente.CPF = "00000000000";
            cliente.Data_Nascimento = DateTime.Now;
            cliente.Endereco = "Rua nossa senhora da luz, n 8, Salvador, BA";
            cliente.Telefone = "71999999999";
            cliente.Situacao = Situacao.Ativo;
            dbcontext.Add(cliente);
            dbcontext.SaveChanges();
            //Fim do Teste

            ViewData["clientes"] = dbcontext.Clientes.Where(p => p.Id>0).ToList();
            return View();
        }
    }
}
