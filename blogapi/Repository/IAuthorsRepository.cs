using blogapi.Models;

namespace blogapi.Repository
{
    public interface IAuthorsRepository
    {
        public Task<IEnumerable<Author>> GetAuthorsAsync();
    }
}
