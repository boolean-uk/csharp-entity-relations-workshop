using blogapi.Models;

namespace blogapi.DTO
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PostDTO> Posts { get; set; } = new List<PostDTO>();

        public AuthorResponseDTO(Author author)
        {
            Id = author.Id;
            Name = author.Name;

            Posts = new List<PostDTO>();
            foreach (var post in author.Posts)
            {
                Posts.Add(new PostDTO(post));
            }
        }

        public static List<AuthorResponseDTO> FromRepository(IEnumerable<Author> authors)
        {
            var results = new List<AuthorResponseDTO>();
            foreach (var author in authors)
            {
                results.Add(new AuthorResponseDTO(author));

            }
            return results;
        }
    }
}
