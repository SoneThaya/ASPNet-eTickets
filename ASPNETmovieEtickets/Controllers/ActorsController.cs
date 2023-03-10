using ASPNETmovieEtickets.Data;
using ASPNETmovieEtickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETmovieEtickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsServices _service;

        public ActorsController(IActorsServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        // GET: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
