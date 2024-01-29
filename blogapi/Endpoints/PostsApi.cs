using blogapi.Repository;

namespace blogapi.Endpoints
{
    public static class PostsApi
    {
        public static void ConfigurePostsApi(this WebApplication app)
        {
            app.MapGet("/posts", GetPosts);
        }

        public static async Task<IResult> GetPosts(IPostsRepository postsRepository)
        {
            return TypedResults.Ok(await postsRepository.GetPostsAsync());
        }

    }
}
