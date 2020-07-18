using Model;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IAuthorService
    {

        List<Author> GetAllAuthors();

        Author GetAuthorById(int id);

        List<BlogPost> GetPostsByAuthor(int id);
    }
}
