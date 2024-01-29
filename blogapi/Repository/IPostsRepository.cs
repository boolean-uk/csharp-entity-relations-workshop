using blogapi.Models;

namespace blogapi.Repository
{
    public interface IPostsRepository
    {
        public Task<IEnumerable<Post>> GetPostsAsync();
        public Task<Post?> GetPost(int postId);
        public void SaveChanges();

    }
}
