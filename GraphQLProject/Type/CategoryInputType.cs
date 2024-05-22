using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class CategoryInputType : InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            
            Field<StringGraphType>("imageurl");
            
        } 
    }
}
/*go to the mutation folder and create mutations
 Add the fields according to the category class*/