﻿using ASPNETmovieEtickets.Data;
using ASPNETmovieEtickets.Data.Services;
using ASPNETmovieEtickets.Models;
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
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // GET: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction("Index");
        }

        // GET: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if(actorDetails == null)
            {
                return View("Empty");
            }
            return View(actorDetails);
        }
    }
}
