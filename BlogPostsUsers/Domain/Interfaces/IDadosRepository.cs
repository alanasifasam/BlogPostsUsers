using BlogPostsUsers.Domain.Model.DTOs;

namespace BlogPostsUsers.Domain.Interfaces
{
    public interface IDadosRepository
    {
        Task SaveUser(IList<UserDTO> userDTOs);
        Task SavePost(IList<BlogDTO> BlogDTOs);
    }
}
