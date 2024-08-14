using Microsoft.AspNetCore.Mvc;
using aulas.Models;

namespace aulas.Controllers
{
    public class EmpresasController : Controller
    {
        private static List<Empresa> empresas = new List<Empresa>
        {
            new Empresa
            {
                Id = 1,
                Nome = "A Pagina",
                End = "Travessa da CDL, 123 - Centro, Ji-PR",
                Cat = "Revendedora",
            },
            new Empresa
            {
                Id = 2,
                Nome = "Livrarias Curitiba",
                End = "Rua das Fiandeiras, 321 - Vila Olímpia, São Paulo - SP",
                Cat = "Revendedora",
            },
            new Empresa
            {
                Id = 3,
                Nome = "FTD",
                End = "Rua Maria Luísa do Val Penteado, 124 - Cidade São Mateus, São Paulo - SP",
                Cat = "Editora",
            },
        };

        public IActionResult Index()
        {
            return View(empresas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Empresa emnpresa)
        {
            emnpresa.Id = empresas.Max(p => p.Id) + 1;
            empresas.Add(emnpresa);
            return RedirectToAction("Index");
        }
    }
}
