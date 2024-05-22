using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuRepository menuRepository)
        {
            //create menu
            Field<MenuType>("CreateMenu").Arguments(new QueryArguments(new QueryArgument<MenuInputType>
            {
                Name = "menu",
            })).Resolve(context =>
            {
                return menuRepository.AddMenu(context.GetArgument<Menu>("menu"));
            });

            //update menu
            Field<MenuType>("UpdateMenu").Arguments(
                new QueryArguments(new QueryArgument<IntGraphType>{Name = "menuId"}, 
                new QueryArgument<MenuInputType> { Name = "menu" }
                )).Resolve(context =>
            {
                //create var to hold the arguments
                var menu = context.GetArgument<Menu>("menu");
                var menuId = context.GetArgument<int>("menuId");

                return menuRepository.UpdateMenu(menuId, menu);
            });

            //delete menu
            Field<StringGraphType>("DeleteMenu").Arguments(
                new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" }
                
             )).Resolve(context =>
                {
                    //create var to hold the arguments
                    var menuId = context.GetArgument<int>("menuId");
                    menuRepository.DeleteMenu(menuId);
                    return "The menu with Id " + menuId + " has been deleted successfully";
             });

            
        }
    }
}
/*after creating the mutation, add the schema to the mutation in the MenuSchema class*/