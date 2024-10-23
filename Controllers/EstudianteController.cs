using concurso_p2024.Data;
using concurso_p2024.Models;
using Microsoft.AspNetCore.Mvc;

namespace concurso_p2024.Controllers
{
	public class EstudianteController : Controller
	{
		public readonly ApplicationDbContext _context;

		public EstudianteController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			List<Estudiante> listaEstudiantes = _context.Estudiante.ToList();
			return View(listaEstudiantes);
		}


		[HttpGet]
		public IActionResult Crear()
		{

			return View();
		}

		[HttpPost]
		public IActionResult Crear(Estudiante estudiante)
		{
			if (ModelState.IsValid)
			{
				_context.Estudiante.Add(estudiante);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				return View("Crear", estudiante);
			}

		}
	}
}
