using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlogPostsUsers.Application.Services
{
    
    public class DadosService : IDadosService
    {
        private readonly HttpClient _httpClient;
        private readonly IDadosRepository _dadosRepository;
        

        public DadosService(HttpClient httpClient, IDadosRepository dadosRepository)
        {
            _httpClient = httpClient;
            _dadosRepository = dadosRepository;
        }
        
        public async void SincronizarDados()
        {
            try
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

                _dadosRepository.SaveAsync(dados.users);

            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
