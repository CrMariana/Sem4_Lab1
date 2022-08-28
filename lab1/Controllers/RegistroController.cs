using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab1.Models;

namespace lab1.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ILogger<Registro> _logger;

        public RegistroController(ILogger<Registro> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Registro objMatricula)
        {

            double igv =0.18 , total=0.0;
            total = objMatricula.Creditos*100*1.18;
            
            ViewData["Message"] ="Se registro satisfactoriamente";
            ViewData["TotalCursos"] = "Total Cursos = " + objMatricula.Creditos*100;
            ViewData["Igv"] = "IGV = " + objMatricula.Creditos*igv;
            ViewData["Total"] = "Total = " + total;
            
            
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        
    }
}