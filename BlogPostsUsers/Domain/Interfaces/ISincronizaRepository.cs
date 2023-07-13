using BlogPostsUsers.Domain.Model.DTOs;

namespace BlogPostsUsers.Domain.Interfaces
{
    public interface ISincronizaRepository
    {
        Task SaveUser(IList<UserDTO> userDTOs);
        Task SavePost(IList<PostDTO> BlogDTOs);
    }
}
