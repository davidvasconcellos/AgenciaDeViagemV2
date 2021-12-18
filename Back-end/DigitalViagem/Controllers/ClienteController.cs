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
        [HttpPost]
        [Route("Deletar")]
        public IActionResult Deletar(Cliente cliente)
        {
            var dbcontext = new Contexto();

            var clienteDelete = dbcontext.Clientes.Find(cliente.Id);
            dbcontext.Remove(clienteDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("Atualizar")]
        public IActionResult Atualizar(Cliente novosDadosCliente)
        {
            var dbcontext = new Contexto();

            var antigosDadosCliente = dbcontext.Clientes.Find(novosDadosCliente.Id);

            antigosDadosCliente.Nome = novosDadosCliente.Nome;
            antigosDadosCliente.CPF = novosDadosCliente.CPF;
            antigosDadosCliente.Telefone = novosDadosCliente.Telefone;
            antigosDadosCliente.Endereco = novosDadosCliente.Endereco;
            antigosDadosCliente.Data_Nascimento = novosDadosCliente.Data_Nascimento;
            antigosDadosCliente.Situacao = novosDadosCliente.Situacao;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
