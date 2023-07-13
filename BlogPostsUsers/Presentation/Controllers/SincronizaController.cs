
using BlogPostsUsers.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostsUsers.Presentation.Controllers
{
    [ApiController]
    [Route(template:"v1")]
    public class SincronizaController : ControllerBase
    {

        private readonly ISincronizaService _sincronizaService;
        public SincronizaController(ISincronizaService sincronizaService)
        {
            _sincronizaService = sincronizaService;
        }

        [HttpGet]
        [Route(template: "api/Sincroniza/GetAsync")]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                await _sincronizaService.SincronizarDados();
                return Ok();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
            
        }
    }
}
