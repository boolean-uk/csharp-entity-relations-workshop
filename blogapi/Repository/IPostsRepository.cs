using blogapi.Models;

namespace blogapi.Repository
{
    public interface IPostsRepository
    {
        public Task<IEnumerable<Post>> GetPostsAsync();
    }
}
