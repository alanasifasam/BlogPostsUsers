using System.Text.Json.Serialization;

namespace BlogPostsUsers.Domain.Model
{
    public class Post
    {
        public int id { get; set; }
        public int user_id { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string photo_url { get; set; }
        public string description { get; set; }   
        public string content_text { get; set; }
        public string content_html { get; set; }

    }
}
