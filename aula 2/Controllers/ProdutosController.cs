using Microsoft.AspNetCore.Mvc;
using aulas.Models;

namespace aulas.Controllers
{
    public class ProdutosController : Controller
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Nome = "Harry Potter (Coletanea)",
                Valor = 210.99m,
                Desc = "Um box contendo a coletanea completa da popular saga Harry Potter",
                Cat = "Box",
            },
            new Produto
            {
                Id = 2,
                Nome = "O Homem do Castelo Alto",
                Valor = 34.99m,
                Desc = "1962, a suástica é hasteada em Nova Iorque. A escravidão é legal, os ...",
                Cat = "Ficção Cientifica",
            },
            new Produto
            {
                Id = 3,
                Nome = "O Pequeno Principe",
                Valor = 15.00m,
                Desc = "Certo dia um piloto cai com seu avião no deserto do Saara e encontra um pequeno príncipe ...",
                Cat = "Literatura Infantil",
            },
        };

        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            produto.Id = produtos.Max(p => p.Id) + 1;
            produtos.Add(produto);
            return RedirectToAction("Index");
        }
    }
}
