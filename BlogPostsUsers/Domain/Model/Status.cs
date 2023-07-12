namespace BlogPostsUsers.Domain.Model
{
    public class Status
    {
        public bool success { get; set; }
        public string time { get; set; }
        public string message { get; set; }
        public int total_users { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public IList<User> users { get; set; }
    }
}
