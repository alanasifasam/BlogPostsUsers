namespace BlogPostsUsers.Domain.Model.DTOs
{
    public class UserDTO
    {
        public string last_name { get; set; }
        public string email { get; set; }
        public int id { get; set; }
        public string phone { get; set; }
        public string street { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public double latitude { get; set; }
        public string gender { get; set; }
        public string first_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string job { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public double longitude { get; set; }
    }

}
