using System.Text.Json.Serialization;

namespace blogapi.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonIgnore] // comment this out to get the serialization error
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
