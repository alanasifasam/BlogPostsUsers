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

        [HttpGet]
        [Route(template: "Dados/GetAsync")]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                await _dadosService.SincronizarDados();
                return Ok();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
            
        }
    }
}
