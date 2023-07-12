using BlogPostsUsers.Domain.Model.DTOs;

namespace BlogPostsUsers.Domain.Interfaces
{
    public interface IDadosRepository
    {
        void SaveAsync(IList<UserDTO> userDTOs);
    }
}
