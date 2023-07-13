namespace BlogPostsUsers.Domain.Model.DTOs
{
    public class PostDTO
    {
        public string title { get; set; }
        public string content_text { get; set; }
        public int id { get; set; }
        public string photo_url { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int user_id { get; set; }
        public string description { get; set; }
        public string content_html { get; set; }
        public string category { get; set; }
    }
}
