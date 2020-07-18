using GraphQL.Types;
using Interfaces;
using Schemas;
using Service;

namespace Querys
{
    public class AuthorQuery : ObjectGraphType
{
    public AuthorQuery(IAuthorService authorService)
    {
        int id = 0;
        Field<ListGraphType<AuthorType>>(
        name: "authors", resolve: context =>
        {
            return authorService.GetAllAuthors();
        });
        Field<AuthorType>(
            name: "author",
            arguments: new QueryArguments(new
            QueryArgument<IntGraphType>
            { Name = "id" }),
            resolve: context =>
            {
                id = context.GetArgument<int>("id");
                return authorService.GetAuthorById(id);
            }
        );
        Field<ListGraphType<BlogPostType>>(
            name: "blogs",
            arguments: new QueryArguments(new
            QueryArgument<IntGraphType>
            { Name = "id" }),
            resolve: context =>
            {
                return authorService.GetPostsByAuthor(id);
            }
        );
    }
}
}
