using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace dot_net_core
{
    public class LivrosController: Controller
    {

        public string Detalhes(int id)
        {
            var livroEncontrado = "Nenhum";
            if (id == 1)
            {
                livroEncontrado = "Harry Potter";
            }

            return "Livro encontrado: " + livroEncontrado;
        }

        public IActionResult ParaLer()
        {
            ViewBag.Livro = "Licro: A culpa é das estrela";
            ViewBag.Autor = "Autor: John Green";
            var html = new ViewResult{ViewName = "para-ler"};
            return View("para-ler");
        }
        public static Task LivrosLendo(HttpContext context)
        {
            return context.Response.WriteAsync("Lendo");
        }
        public static Task LivrosLidos(HttpContext context)
        {
            return context.Response.WriteAsync("Lidos");
        }

        public string Teste(){
            return "teste";
        }
    }
}