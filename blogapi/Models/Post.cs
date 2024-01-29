using System.Collections.ObjectModel;

namespace blogapi.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
