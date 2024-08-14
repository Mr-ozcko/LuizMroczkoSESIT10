using Microsoft.AspNetCore.Mvc;
using aulas.Models;

namespace aulas.Controllers;

public class ClientsController : Controller {
    private static List<Client> clients = new List<Client>
        {
            new Client
            {
                Id = 1,
                Nome = "Robson",
                Emp = "Amazonias",
                Mail = "Novo cliente"
            },
            new Client
            {
                Id = 2,
                Nome = "Maria Silva",
                Emp = "Mufatinho",
                Mail = "Cliente regular"
            },
            new Client
            {
                Id = 3,
                Nome = "João Pereira",
                Emp = "A Pagina",
                Mail = "Comprador frequente"
            }
        };
        public IActionResult Index()
        {
            return View(clients);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            client.Id = clients.Max(p => p.Id) + 1;
            clients.Add(client);
            return RedirectToAction("Index");
        }
}