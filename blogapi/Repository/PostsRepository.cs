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
            return await _db.Posts.Include(p => p.Author).Include(p => p.Comments).ToListAsync();
        }

        public async Task<Post?> GetPost(int postId)
        {
            return await _db.Posts.Include(p => p.Author).Include(p => p.Comments).FirstOrDefaultAsync(p => p.Id == postId);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
