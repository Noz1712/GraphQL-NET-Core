using GraphQL;
using GraphQL.Types;
using Querys;

namespace GraphQLUtility
{
    public class GraphQLSchema: Schema, ISchema
    {
        public GraphQLSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AuthorQuery>();
        }
    }
}
