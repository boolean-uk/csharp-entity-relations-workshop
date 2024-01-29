using blogapi.Models;

namespace blogapi.DTO
{
    public class PostResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Text { get; set; }

        public AuthorDTO Author { get; set; }

        public ICollection<CommentDTO> Comments { get; set; } = new List<CommentDTO>();

        public PostResponseDTO(Post post)
        {
            Id = post.Id;
            Title = post.Title;
            Text = post.Text;

            Author = new AuthorDTO(post.Author);
            Comments = new List<CommentDTO>();
            foreach (var comment in post.Comments)
            {
                Comments.Add(new CommentDTO(comment));
            }
        }

        public static List<PostResponseDTO> FromRepository(IEnumerable<Post> posts)
        {
            var results = new List<PostResponseDTO>();
            foreach (var post in posts)
            {
                results.Add(new PostResponseDTO(post));

            }
            return results;
        }
    }
}
