using blogapi.Models;

namespace blogapi.DTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AuthorDTO(Author author)
        {
            Id = author.Id;
            Name = author.Name;
        }

    }
}
