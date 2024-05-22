namespace GraphQLProject.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string   ImageUrl { get; set; }

        //this one way to create a oneToMany relationship between category and Menu tables
        //there are other ways too
        public ICollection<Menu> Menus{ get; set; } 
    }
}
