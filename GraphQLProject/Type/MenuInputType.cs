using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<FloatGraphType>("price");//there is no double type in graphQL
            Field<StringGraphType>("imageurl");
            Field<IntGraphType>("categoryId");
        } 
    }
}
/*go to the mutation folder and create mutations*/