using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuRepository menuRepository)
        {   
            //list of menus
            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuRepository.GetAllMenu();
            });

            //a single menu
            Field<MenuType>("Menu").Arguments(new QueryArguments(new QueryArgument<IntGraphType>
            {
                Name = "menuId",
            })).Resolve(context =>
            {
                return menuRepository.GetMenuById(context.GetArgument<int>("menuId"));
            });
        }
    }
}
/*Query -->will contain only Get methods
 * we need to derive the class from the object GraphType*/