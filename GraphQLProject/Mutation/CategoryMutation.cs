using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class CategoryMutation : ObjectGraphType
    {
        public CategoryMutation(ICategoryRepository categoryRepository)
        {
            //create category
            Field<CategoryType>("CreateCategory").Arguments(new QueryArguments(new QueryArgument<CategoryInputType>
            {
                Name = "category",
            })).Resolve(context =>
            {
                return categoryRepository.AddCategory(context.GetArgument<Category>("category"));
            });

            //update category
            Field<CategoryType>("UpdateCategory").Arguments(
                new QueryArguments(new QueryArgument<IntGraphType>{Name = "categoryId"}, 
                new QueryArgument<CategoryInputType> { Name = "category" }
                )).Resolve(context =>
            {
                //create var to hold the arguments
                var category = context.GetArgument<Category>("category");
                var categoryId = context.GetArgument<int>("categoryId");

                return categoryRepository.UpdateCategory(categoryId, category);
            });

            //delete category
            Field<StringGraphType>("DeleteCategory").Arguments(
                new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId" }
                
             )).Resolve(context =>
                {
                    //create var to hold the arguments
                    var categoryId = context.GetArgument<int>("categoryId");
                    categoryRepository.DeleteCategory(categoryId);
                    return "The category with Id " + categoryId + " has been deleted successfully";
             });

            
        }
    }
}
/*after creating the mutation, add the schema to the mutation in the MenuSchema class*/