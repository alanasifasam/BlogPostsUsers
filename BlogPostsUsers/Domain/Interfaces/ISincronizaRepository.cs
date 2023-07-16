using BlogPostsUsers.Domain.Model;
using BlogPostsUsers.Domain.Model.DTOs;

namespace BlogPostsUsers.Domain.Interfaces
{
    public interface ISincronizaRepository
    {
        Task SaveUser(IList<UserDTO> userDTOs);
        Task SavePost(IList<PostDTO> BlogDTOs);
        void SaveStatusPost(StatusPost statusPost);
        void SaveStatusUser(StatusUser statusUser);
        StatusUser GetOffset(int offset);
        StatusPost GetOffsetPost(int offpost);
    }
}
