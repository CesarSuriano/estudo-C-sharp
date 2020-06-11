using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace dot_net_core
{
    public class CadastroController
    {

        public IActionResult ExibeFormulario()
        {
            // var html = HTMLUtils.CarregaArquivoHTML("formulario");
            var html = new ViewResult{ViewName = "formulario"};
            return html;
        }


        public static Task NovoLivroParaLer(HttpContext context)
        {
            var titulo = context.GetRouteValue("nome").ToString();
            var autor = context.GetRouteValue("autor").ToString();

            return context.Response.WriteAsync("O livro " + titulo + " do autor " + autor + " foi adicionado com sucesso");
        }
    }
}