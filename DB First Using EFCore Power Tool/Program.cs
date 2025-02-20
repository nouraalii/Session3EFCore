using DB_First_Using_EFCore_Power_Tool.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DB_First_Using_EFCore_Power_Tool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindDbContext context = new NorthwindDbContext();

            //var result = context.Categories.ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            //Run Sql Query
            //1.Select Statments : FromSqlRow() , FromSqlInterpolated()

            //var result = context.Categories.FromSqlRaw("Select * From Categories");
            //var result = context.Categories.FromSqlRaw("Select * From Products where UnitsInStock = 0");

            //int Price =10;
            //var result = context.Categories.FromSqlRaw("Select * From Products where UnitPrice > {0}",Price);
            //var result = context.Categories.FromSqlInterpolated($"Select * From Products where UnitPrice > {Price}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            ////2.DML Statments [Insert - Upadte - Delete] : ExecuteSqlRow() , ExecuteSqlInterploated()
            
            //context.Database.ExecuteSqlRaw("Update Products Set UnitsInStock = 40 where ProductID = 1");

        }
    }
}
