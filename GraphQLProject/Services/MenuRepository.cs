using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class MenuRepository : IMenuRepository
    {
        //inject the GraphQLDContext ctor for the class which takes the GraphQLDbContext as Args
        private GraphQLDbContext dbContext;
        public MenuRepository(GraphQLDbContext dbContex)
        {
            this.dbContext = dbContex;
        }

        public Menu AddMenu(Menu menu)
        {
           dbContext.Menus.Add(menu);
           dbContext.SaveChanges();
           return menu;
        }

        public void DeleteMenu(int id)
        {
            //first find the menu by id
            var menuResult = dbContext.Menus.Find(id);
            dbContext.Menus.Remove(menuResult);
            //save changes
            dbContext.SaveChanges();
        }

        public List<Menu> GetAllMenu()
        {
            return dbContext.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            return dbContext.Menus.Find(id);//you can use first or default as well
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            //first find the menu by id
            var menuResult = dbContext.Menus.Find(id);
            //replace/update the existing data
            menuResult.Name = menu.Name;
            menuResult.Description = menu.Description; 
            menuResult.Price = menu.Price;
            //save changes
            dbContext.SaveChanges();
            return menu;
        }
    }
}
/*implement all methods in the IMenuRepository class here
 But why is the folder not named repository??? but services
 */