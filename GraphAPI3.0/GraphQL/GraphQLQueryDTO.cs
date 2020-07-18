using GraphQL;

namespace GraphQLUtility
{
    public class GraphQLQueryDTO
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public ExecutionOptions Variables { get; set; }
    }
}
