using BlogPostsUsers.Domain.Model.DTOs;

namespace BlogPostsUsers.Domain.Model
{
    public class StatusBlog
    {
        public bool success { get; set; }
        public string message { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public IList<BlogDTO> blogs { get; set; }
    }
}
