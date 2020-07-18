using Interfaces;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class AuthorRepository: Interfaces.IAuthorRepository
    {
        private readonly List<Author> authors = new List<Author>();
        private readonly List<BlogPost> posts = new List<BlogPost>();

        public AuthorRepository()
        {

            Author author1 = new Author
            {
                Id = 1,
                FirstName = "Joydip",
                LastName = "Kanjilal"
            };

            Author author2 = new Author
            {
                Id = 2,
                FirstName = "Steve",
                LastName = "Smith"
            };

            BlogPost csharp = new BlogPost
            {
                Id = 1,
                Title = "Mastering C#",
                Content = "This is a series of articles on C#.",
                Author = author1
            };

            BlogPost java = new BlogPost
            {
                Id = 2,
                Title = "Mastering Java",
                Content = "This is a series of articles on Java",
                Author = author1
            };

            posts.Add(csharp);
            posts.Add(java);

            authors.Add(author1);
            authors.Add(author2);
        }
        public List<Author> GetAllAuthors()
        {
            return this.authors;
        }

        public Author GetAuthorById(int id)
        {
            return authors.Where(author => author.Id ==
            id).FirstOrDefault<Author>();
        }

        public List<BlogPost> GetPostsByAuthor(int id)
        {
            return posts.Where(post => post.Author.Id ==
            id).ToList<BlogPost>();
        }
    }
}
