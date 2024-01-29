using blogapi.Repository;

namespace blogapi.Endpoints
{
    public static class AuthorsApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
        }

        public static async Task<IResult> GetAuthors(IAuthorsRepository authorsRepository)
        {
            return TypedResults.Ok(await authorsRepository.GetAuthorsAsync());
        }
    }
}
