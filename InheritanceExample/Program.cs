using InheritanceExample.Context;
using InheritanceExample.Models;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main()
        {
            //3 Ways to generate schema 
            //1.TPC  : Table Per Class
            //2.TPH  : Table Per Heriarchy
            //3.TPCC : Table Per Concert Class

            using AppDbContext context = new AppDbContext();

            //FullTimeEmployee fullTimeEmployee01 = new FullTimeEmployee()
            //{
            //    Name = "Noura",
            //    Address = "Cairo",
            //    Email = "Noura@gmail.come",
            //    Salary = 20000
            //};

            //FullTimeEmployee fullTimeEmployee02 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Address = "Alex",
            //    Email = "Ahmed@gmail.come",
            //    Salary = 15000
            //};

            //FullTimeEmployee fullTimeEmployee03 = new FullTimeEmployee()
            //{
            //    Name = "Dina",
            //    Address = "Giza",
            //    Email = "Dina@gmail.come",
            //    Salary = 19000
            //};

            //context.FullTimeEmployees.Add(fullTimeEmployee03);

            //context.SaveChanges();

            //PartTimeEmployee partTimeEmployee01 = new PartTimeEmployee()
            //{
            //    Name = "Noura",
            //    Address = "Cairo",
            //    Email = "Noura@gmail.come",
            //    HourRate=300,
            //    NumberOfHours=200
            //};

            //PartTimeEmployee partTimeEmployee02 = new PartTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Address = "Alex",
            //    Email = "Ahmed@gmail.come",
            //    HourRate = 100,
            //    NumberOfHours = 200
            //};

            //PartTimeEmployee partTimeEmployee03 = new PartTimeEmployee()
            //{
            //    Name = "Dina",
            //    Address = "Giza",
            //    Email = "Dina@gmail.come",
            //    HourRate = 300,
            //    NumberOfHours = 300
            //};

            //context.FullTimeEmployees.Add(fullTimeEmployee01);
            //context.FullTimeEmployees.Add(fullTimeEmployee02);
            //context.FullTimeEmployees.Add(fullTimeEmployee03);

            //context.PartTimeEmployees.Add(partTimeEmployee01);
            //context.PartTimeEmployees.Add(partTimeEmployee02);
            //context.PartTimeEmployees.Add(partTimeEmployee03);

            //context.SaveChanges(); //Remotly

            //var result = context.Employees.OfType<FullTimeEmployee>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in context.PartTimeEmployees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var result = context.FullTimeEmployees.FirstOrDefault(E=>E.Id==1);
            //Console.WriteLine(result.Name);
        }
    }
}
