﻿using Microsoft.AspNetCore.Mvc;

namespace ProyectoGit4.Controllers
{
    public class ManualController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Servicios()
        {
            return View();
        }
    }
}
