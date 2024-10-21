using Microsoft.AspNetCore.Mvc;
using RecodeProject.Models;

namespace RecodeProject.Controllers
{
    public class HomeEFController : Controller
    {
        private CursoDbContext _context;
        public HomeEFController(CursoDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var cursos = _context.Curso.ToList();
            return View(cursos);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso) {
            _context.Add(curso);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET
        public IActionResult Edit(int? id) {
            if (id == null) { 
                return NotFound();
            }

            var update_curso = _context.Curso.SingleOrDefault(a => a.ID == id);

            if (update_curso == null) {
                return NotFound();
            }

            return View(update_curso);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Curso curso) {
            if (id != curso.ID) {
                return NotFound();
            }

            if (ModelState.IsValid) { 
                _context.Update(curso);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(curso);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delete_curso = _context.Curso.SingleOrDefault(a => a.ID == id);

            if (delete_curso == null)
            {
                return NotFound();
            }

            return View(delete_curso);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id) {
            var curso = _context.Curso.SingleOrDefault(a => a.ID == id);
            if(curso == null)
            {
                return NotFound();
            }

            _context.Curso.Remove(curso);
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id) { 
            if(id == null)
            {
                return NotFound();
            }

            var curso_details = _context.Curso.SingleOrDefault(a => a.ID == id);

            return View(curso_details);
        }
    }
}
