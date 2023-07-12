using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using BlogPostsUsers.Domain.Model.DTOs;
using BlogPostsUsers.Infrastructure.DBContext;

namespace BlogPostsUsers.Infrastructure.Repository
{
    public class DadosRepository : IDadosRepository 
    {
        private readonly ContextDb _dbContext;

        public DadosRepository(ContextDb dbContext)
        {
            _dbContext = dbContext;
        }

        public async void SaveAsync(IList<UserDTO> userDTOs)
        {
            try
            {
                 
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
