using Microsoft.AspNetCore.Mvc;

namespace BlogPostsUsers.Domain.Interfaces
{
    public interface IDadosService
    {
        Task<IActionResult> SincronizarDados();
    }
}
