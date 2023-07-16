using BlogPostsUsers.Domain.Model.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogPostsUsers.Domain.Model
{
    public class StatusUser
    {
        [Key]
        public int Id { get; set; }
        public bool success { get; set; }
        public string time { get; set; }
        public string message { get; set; }
        public int total_users { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        [NotMapped]
        public IList<UserDTO>? users { get; set; }
    }
}
