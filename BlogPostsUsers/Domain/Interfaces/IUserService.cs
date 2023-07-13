using BlogPostsUsers.Domain.Model;

namespace BlogPostsUsers.Domain.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
    }
}
