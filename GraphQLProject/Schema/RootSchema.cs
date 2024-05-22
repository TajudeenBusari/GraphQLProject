using GraphQLProject.Mutation;
using GraphQLProject.Query;

namespace GraphQLProject.Schema
{
    public class RootSchema: GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            //query
            Query = serviceProvider.GetRequiredService<RootQuery>();

            //mutation
            Mutation = serviceProvider.GetRequiredService<RootMutation>();

        }
    }
}
/*this is how to deal with multiple qury classes*/