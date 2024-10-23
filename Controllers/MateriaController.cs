using concurso_p2024.Data;
using concurso_p2024.Models;
using Microsoft.AspNetCore.Mvc;

namespace concurso_p2024.Controllers
{
    public class MateriaController : Controller
    {
        //Crear variable
        public readonly ApplicationDbContext _context;

        //Crear constructor
        public MateriaController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Metodos de accion 
        public IActionResult Index()
        {
            List<Materia> listaMateria = _context.Materia.ToList();
            return View(listaMateria);
        }


        [HttpGet]
        public IActionResult Crear()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Crear(Materia materia)
        {
            if (ModelState.IsValid)
            {
                _context.Materia.Add(materia);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Crear", materia);
            }

        }
    }
}
