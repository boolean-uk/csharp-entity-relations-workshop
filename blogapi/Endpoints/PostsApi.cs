using blogapi.DTO;
using blogapi.Models;
using blogapi.Repository;

namespace blogapi.Endpoints
{
    public record UpdatePostAuthorRequestDTO(int authorId);




    public static class PostsApi
    {
        public static void ConfigurePostsApi(this WebApplication app)
        {
            app.MapGet("/posts", GetPosts);
            app.MapPut("/posts/{postId}/author/", UpdatePostAuthor);
        }

        public static async Task<IResult> GetPosts(IPostsRepository postsRepository)
        {
            var posts = await postsRepository.GetPostsAsync();
            return TypedResults.Ok(PostResponseDTO.FromRepository(posts));
        }


        public static async Task<IResult> UpdatePostAuthor(int postId, UpdatePostAuthorRequestDTO payload, IPostsRepository postsRepository, IAuthorsRepository authorsRepository)
        {
            // get the post
            Post? post = await postsRepository.GetPost(postId);
            if(post == null)
            {
                return TypedResults.NotFound();
            }
            Author? author = await authorsRepository.GetAuthor(payload.authorId);
            if (author == null)
            {
                return TypedResults.NotFound();
            }
            post.AuthorId = author.Id;
            post.Author = author;

            postsRepository.SaveChanges();

            return TypedResults.Ok(new PostResponseDTO(post));
        }
    }
}
