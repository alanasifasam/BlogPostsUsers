using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlogPostsUsers.Application.Services
{
    
    public class DadosService : IDadosService
    {
        private readonly HttpClient _httpClient;
        

        public DadosService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<IActionResult> SincronizarDados()
        {
            var url = "https://api.slingacademy.com/v1/sample-data/";

            var responseTasks = Task.WhenAll(
                    _httpClient.GetAsync($"{url}users?offset=0&limit=100"),
                    _httpClient.GetAsync($"{url}blog-posts?offset=0&limit=100")
                );

            var responses = await responseTasks;
            var contentUser = await responses[0].Content.ReadAsStringAsync();
            var contentBlog = await responses[1].Content.ReadAsStringAsync();

            var dados = JsonConvert.DeserializeObject<Status>(contentUser);
            var dados2 = JsonConvert.DeserializeObject<StatusBlog>(contentBlog);

            return null;
        }

    }
}
