using Microsoft.AspNetCore.Mvc;
using RecodeProject.Models;
using System.Diagnostics;

namespace RecodeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static IList<Curso> cursos = new List<Curso>
        {
            new Curso()
            {
                ID = 1,
                Description = "Asp Net MVC",
                Workload = 40
            },
            new Curso()
            {
                ID = 2,
                Description = "Banco de Dados",
                Workload =  30
            },
            new Curso()
            {
                ID = 3,
                Description = "React",
                Workload = 60
            },
            new Curso()
            {
                ID = 4,
                Description = "HTML e CSS",
                Workload = 20
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cursos()
        {
            return View(cursos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
