using BlogPostsUsers.Domain.Model.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogPostsUsers.Domain.Model
{
    public class StatusPost
    {
        [Key]
        public int Id { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        [NotMapped]
        public IList<PostDTO>? Blogs { get; set; }
    }
}
