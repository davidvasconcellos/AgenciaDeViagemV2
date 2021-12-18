using Microsoft.AspNetCore.Mvc;

namespace DigitalViagem.Controllers
{
    public class DestinosController : Controller
    {
        public IActionResult Viagem()
        {
            return View();
        }
    }
}
