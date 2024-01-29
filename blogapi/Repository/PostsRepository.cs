using blogapi.Data;
using blogapi.Models;
using Microsoft.EntityFrameworkCore;

namespace blogapi.Repository
{
    public class PostsRepository: IPostsRepository
    {
        DataContext _db;

        public PostsRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Post>> GetPostsAsync()
        {
            return await _db.Posts.ToListAsync();
        }
    }
}
