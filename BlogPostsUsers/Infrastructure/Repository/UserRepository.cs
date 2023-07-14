using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using BlogPostsUsers.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace BlogPostsUsers.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ContextDb _dbContext;

        public UserRepository(ContextDb dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            try
            {
                var users = await _dbContext.Users.ToListAsync();
                return users;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetUserById(int Id)
        {
            try
            {
                var user =  _dbContext.Users.Include(x => x.Posts).FirstOrDefault(x => x.id == Id);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
