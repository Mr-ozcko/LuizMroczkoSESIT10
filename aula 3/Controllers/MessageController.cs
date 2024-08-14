using Microsoft.AspNetCore.Mvc;
using message.Models;
using System.Collections.Generic;

    namespace message.Controllers{

        public class MessageController : Controller{

            // Lista estática para armazenar as mensagens
            private static List<Message> messages = new List<Message>();

            public IActionResult Index(){

                return View();  

            }

            [HttpPost]
            public IActionResult Index(Message message){

                // Adiciona a nova mensagem à lista
                messages.Add(message);

                // Passa a lista de mensagens para a view
                return View();
            }


            [HttpGet]

            public IActionResult Saved(){

                return View(messages);  

            }



        }
    }