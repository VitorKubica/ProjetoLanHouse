using Checkpoint1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint1.Controllers
{
    public class LanHouseController : Controller
    {
        private readonly Reserva reserva;

        public LanHouseController()
        {
            reserva = new Reserva();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Reservar(Cliente cliente, Computador computador)
        {
            reserva.AdicionarReserva(cliente, computador);
            return RedirectToAction("Index");
        }
    }
}
