using BlogPostsUsers.Application.Services;
using BlogPostsUsers.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostsUsers.Presentation.Controllers
{
    [ApiController]
    [Route(template:"V1")]
    public class DadosController : ControllerBase
    {

        private readonly IDadosService _dadosService;
        public DadosController(IDadosService dadosService)
        {
            _dadosService = dadosService;
        }

        [HttpPost]
        [Route(template: "Dados/PostAsync")]
        public async Task<IActionResult> PostAsync()
        {
            var ok = await _dadosService.SincronizarDados();
            return Ok();
        }
    }
}
