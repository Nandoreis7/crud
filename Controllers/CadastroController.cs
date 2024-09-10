using CadastroApp.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CadastroApp.Controllers
{
    public class CadastroController : Controller
    {
        private readonly AppDbContext _context;

        public CadastroController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cadastros = _context.Cadastros.ToList();
            return View(cadastros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                _context.Cadastros.Add(cadastro);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastro);
        }

        public IActionResult Delete(int id)
        {
            var cadastro = _context.Cadastros.FirstOrDefault(c => c.Id == id);

            if (cadastro == null)
            {
                return NotFound();
            }

            _context.Cadastros.Remove(cadastro);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
