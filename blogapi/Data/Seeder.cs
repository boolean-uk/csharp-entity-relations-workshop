using blogapi.Models;

namespace blogapi.Data
{
    public class Seeder
    {
        private List<string> _firstnames = new List<string>()
        {
            "Audrey",
            "Donald",
            "Elvis",
            "Barack",
            "Oprah",
            "Jimi",
            "Mick",
            "Kate",
            "Charles",
            "Kate"
        };
        private List<string> _lastnames = new List<string>()
        {
            "Hepburn",
            "Trump",
            "Presley",
            "Obama",
            "Winfrey",
            "Hendrix",
            "Jagger",
            "Winslet",
            "Windsor",
            "Middleton"

        };
        private List<string> _domain = new List<string>()
        {
            "bbc.co.uk",
            "google.com",
            "theworld.ca",
            "something.com",
            "tesla.com",
            "nasa.org.us",
            "gov.us",
            "gov.gr",
            "gov.nl",
            "gov.ru"
        };
        private List<string> _firstword = new List<string>()
        {
            "The",
            "Two",
            "Several",
            "Fifteen",
            "A bunch of",
            "An army of",
            "A herd of"


        };
        private List<string> _secondword = new List<string>()
        {
            "Orange",
            "Purple",
            "Large",
            "Microscopic",
            "Green",
            "Transparent",
            "Rose Smelling",
            "Bitter"
        };
        private List<string> _thirdword = new List<string>()
        {
            "Buildings",
            "Cars",
            "Planets",
            "Houses",
            "Flowers",
            "Leopards"
        };

        private List<Author> _authors = new List<Author>();
        private List<Post> _posts = new List<Post>();
        private List<Comment> _comments = new List<Comment>();

        public List<Author> Authors { get { return _authors; } }
        public List<Post> Posts { get { return _posts; } }
        public List<Comment> Comments { get { return _comments; } }

        public Seeder()
        {
            Random authorRandom = new Random();
            Random postRandom = new Random();
            Random commentRandom = new Random();

            for (int x = 1; x < 10; x++)
            {
                Author author = new Author();
                author.Id = x;
                author.Name = _firstnames[authorRandom.Next(_firstnames.Count)] + " " + _lastnames[authorRandom.Next(_lastnames.Count)];
                _authors.Add(author);
            }

            for (int y = 1; y < 10; y++)
            {
                Post post = new Post();
                post.Id = y;
                post.Title = $"{_firstword[postRandom.Next(_firstword.Count)]} {_secondword[postRandom.Next(_secondword.Count)]} {_thirdword[postRandom.Next(_thirdword.Count)]}";
                post.Text = $"{_firstword[postRandom.Next(_firstword.Count)]} {_secondword[postRandom.Next(_secondword.Count)]} {_thirdword[postRandom.Next(_thirdword.Count)]}";

                post.AuthorId = _authors[authorRandom.Next(_authors.Count)].Id;

                _posts.Add(post);
            }


            for (int y = 1; y < 50; y++)
            {
                Comment comment = new Comment();
                comment.Id = y;
                comment.Text = $"{_firstword[commentRandom.Next(_firstword.Count)]} {_secondword[commentRandom.Next(_secondword.Count)]} {_thirdword[commentRandom.Next(_thirdword.Count)]}";

                comment.PostId = _posts[postRandom.Next(_posts.Count)].Id;

                _comments.Add(comment);
            }
        }
    }
}
