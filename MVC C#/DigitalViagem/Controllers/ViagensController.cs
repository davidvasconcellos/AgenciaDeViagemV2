using DigitalViagem.Models;
using DigitalViagem.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using DigitalViagem.Enum;

namespace DigitalViagem.Controllers
{
    [Route("Viagem")]
    public class ViagensController : Controller
    {
        //Método GET
        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["viagens"] = dbcontext.Viagems.Where(p => p.Id > 0).ToList();
            return View();
        }

        //Método POST
        [HttpPost]
        [Route("Incluir")]
        public IActionResult Incluir(Viagem viagem)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(viagem);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("Deletar")]
        public IActionResult Deletar(Viagem viagem)
        {
            var dbcontext = new Contexto();

            var viagemDelete = dbcontext.Viagems.Find(viagem.Id);
            dbcontext.Remove(viagemDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("Atualizar")]
        public IActionResult Atualizar(Viagem novosDadosViagem)
        {
            var dbcontext = new Contexto();

            var antigosDadosViagem = dbcontext.Viagems.Find(novosDadosViagem.Id);

            antigosDadosViagem.Origem = novosDadosViagem.Origem;
            antigosDadosViagem.Destino = novosDadosViagem.Destino;
            antigosDadosViagem.DataPartida = novosDadosViagem.DataPartida;
            antigosDadosViagem.DataVolta = novosDadosViagem.DataVolta;
            antigosDadosViagem.Valor = novosDadosViagem.Valor;
            antigosDadosViagem.Status = novosDadosViagem.Status;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
