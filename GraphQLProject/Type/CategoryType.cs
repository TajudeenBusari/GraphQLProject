using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Services;

namespace GraphQLProject.Type
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType(IMenuRepository menuRepository)
        {
            //define fields based on the properties of the category class
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.ImageUrl);
            //for nested query
            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuRepository.GetAllMenu();
            });

          

        }
    }
}