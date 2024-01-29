using blogapi.Models;

namespace blogapi.DTO
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public CommentDTO(Comment comment)
        {
            Id = comment.Id;
            Text = comment.Text;
        }
    }
}
