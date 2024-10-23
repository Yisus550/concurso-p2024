using concurso_p2024.Data;
using concurso_p2024.Models;
using Microsoft.AspNetCore.Mvc;

namespace concurso_p2024.Controllers
{
    public class ProfesorController : Controller
    {
        //Crear variable
        public readonly ApplicationDbContext _context;

        //Crear constructor
        public ProfesorController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Metodos de accion 
        public IActionResult Index()
        {
            List<Profesor> listaProfesor = _context.Profesor.ToList();
            return View(listaProfesor);
        }


        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Profesor profesor)
        {
            if (ModelState.IsValid)
            {
                _context.Profesor.Add(profesor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Crear", profesor);
            }

        }

    }
}
