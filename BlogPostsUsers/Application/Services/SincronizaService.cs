using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using Newtonsoft.Json;

namespace BlogPostsUsers.Application.Services
{
    
    public class SincronizaService : ISincronizaService
    {
        private readonly HttpClient _httpClient;
        private readonly ISincronizaRepository _sincronizaRepository;
        

        public SincronizaService(HttpClient httpClient, ISincronizaRepository sincronizaRepository)
        {
            _httpClient = httpClient;
            _sincronizaRepository = sincronizaRepository;
        }
        
        public async Task SincronizarDados()
        {
            try
            {
                var url = "https://api.slingacademy.com/v1/sample-data/";
                var limit = 100;
                var offset = 0;

                while (offset <= 900) 
                {
                    var responseTasks = Task.WhenAll(
                        _httpClient.GetAsync($"{url}users?offset={offset}&limit={limit}"),
                        _httpClient.GetAsync($"{url}blog-posts?offset={offset}&limit={limit}")
                    );

                    var responses = await responseTasks;
                    var contentUser = await responses[0].Content.ReadAsStringAsync();
                    var contentBlog = await responses[1].Content.ReadAsStringAsync();

                    var dados = JsonConvert.DeserializeObject<Status>(contentUser);
                    var dados2 = JsonConvert.DeserializeObject<StatusPost>(contentBlog);

                    await _sincronizaRepository.SaveUser(dados.users);
                    await _sincronizaRepository.SavePost(dados2.Blogs);

                    offset = offset + limit;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
