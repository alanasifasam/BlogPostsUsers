using BlogPostsUsers.Domain.Model.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostsUsers.Domain.Interfaces
{
    public interface IDadosService
    {
        Task SincronizarDados();
        
    }
}
