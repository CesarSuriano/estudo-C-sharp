using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace dot_net_core
{
    public class Startup
    {

        public void Configure(IApplicationBuilder app)
        {
            var builder = new RouteBuilder(app);
            builder.MapRoute("Livros/ParaLer", LivrosParaLer);
            builder.MapRoute("Livros/Lendo", LivrosLendo);
            builder.MapRoute("Livros/Lidos", LivrosLidos);
            builder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", NovoLivroParaLer);
            builder.MapRoute("Livros/Detalhes/{id:int}", ExibeDetalhe);
            builder.MapRoute("Cadastro/NovoLivro", ExibeForulario);
            builder.MapRoute("Cadastro/Incluir", ProcessaFormulario);


            var rotas = builder.Build();
            app.UseRouter(rotas);
            //app.Run(Roteamento);
            Console.WriteLine("No configure");
        }

        private Task ProcessaFormulario(HttpContext context)
        {
            var titulo = context.Request.Form["titulo"];
            var autor = context.Request.Form["autor"];

            return context.Response.WriteAsync("O livro " + titulo + " do autor " + autor + " foi adicionado com sucesso");
        }

        private Task ExibeForulario(HttpContext context)
        {
            var html = CarregaArquivoHTML("formulario");
            return context.Response.WriteAsync(html);
        }

        private string CarregaArquivoHTML(string nomeArquivo)
        {
            var nomeCompletoArquivo = $"Views/{nomeArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }

        private Task ExibeDetalhe(HttpContext context)
        {
            int id = Convert.ToInt32(context.GetRouteValue("id"));

            var livroEncontrado = "Nenhum";
            if (id == 1)
            {
                livroEncontrado = "Harry Potter";
            }

            return context.Response.WriteAsync("Livro encontrado: " + livroEncontrado);
        }

        private Task NovoLivroParaLer(HttpContext context)
        {
            var titulo = context.GetRouteValue("nome").ToString();
            var autor = context.GetRouteValue("autor").ToString();

            return context.Response.WriteAsync("O livro " + titulo + " do autor " + autor + " foi adicionado com sucesso");
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public Task Roteamento(HttpContext context)
        {
            var caminhosAtendidos = new Dictionary<string, RequestDelegate>
            {
                {"/Livros/ParaLer", LivrosParaLer},
                {"/Livros/Lendo", LivrosLendo},
                {"/Livros/Lidos", LivrosLidos}
            };

            if (caminhosAtendidos.ContainsKey(context.Request.Path))
            {
                var metodo = caminhosAtendidos[context.Request.Path];
                return metodo.Invoke(context);
            }

            context.Response.StatusCode = 404;
            return context.Response.WriteAsync("URL desconhecida");

        }

        public Task LivrosParaLer(HttpContext context)
        {
            var titulo = "Titulo";
            var autor = "autor";
            var conteudoArquivo = CarregaArquivoHTML("para-ler");

            conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", $"<li>{titulo} - {autor}</li>");

            return context.Response.WriteAsync(conteudoArquivo);
        }
        public Task LivrosLendo(HttpContext context)
        {
            return context.Response.WriteAsync("Lendo");
        }
        public Task LivrosLidos(HttpContext context)
        {
            return context.Response.WriteAsync("Lidos");
        }
    }
}
