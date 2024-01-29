using blogapi.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace blogapi.Repository
{
    public interface IAuthorsRepository
    {
        public Task<IEnumerable<Author>> GetAuthorsAsync();

        public Task<Author?> GetAuthor(int authorId);

        public void SaveChanges();
    }
}
