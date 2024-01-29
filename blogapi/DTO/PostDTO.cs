using blogapi.Models;

namespace blogapi.DTO
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Text { get; set; }

        public ICollection<CommentDTO> Comments { get; set; } = new List<CommentDTO>();

        public PostDTO(Post post)
        {
            Id = post.Id;
            Title = post.Title;
            Text = post.Text;

            Comments = new List<CommentDTO>();
            foreach (var comment in post.Comments)
            {
                Comments.Add(new CommentDTO(comment));
            }
        }
    }
}
