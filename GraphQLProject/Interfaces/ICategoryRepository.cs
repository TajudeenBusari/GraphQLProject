using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category UpdateCategory(int id, Category category);
        Category AddCategory(Category category);
        void DeleteCategory(int id);
    }
}
