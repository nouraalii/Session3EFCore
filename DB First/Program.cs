using DB_First.Data.Contexts;
using DB_First.Data.Model;

namespace DB_First
{
    internal class Program
    {
        static void Main()
        {
            using AppDbContext context = new AppDbContext();
           
            //Category category = new Category() 
            //{
            //    CategoryName = "Test",
            //    Description = "Test",
            //};

            //context.Categories.Add(category);

            //context.SaveChanges();

            //var result = context.Categories.ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //    Console.WriteLine();
            //    foreach (var Product in item.Products)
            //    {
            //        Console.WriteLine(Product);
            //    }
            //}


        }
    }
}
