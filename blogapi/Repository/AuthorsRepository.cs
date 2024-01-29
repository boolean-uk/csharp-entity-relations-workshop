using blogapi.Data;
using blogapi.Models;
using Microsoft.EntityFrameworkCore;


namespace blogapi.Repository
{
    public class AuthorsRepository: IAuthorsRepository
    {

        DataContext _db;
        public AuthorsRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Author>> GetAuthorsAsync()
        {
            return await _db.Authors.ToListAsync();
        }
    }
}
