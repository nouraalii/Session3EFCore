using Microsoft.EntityFrameworkCore;
using Session3EFCoreDemo.Context;
using Session3EFCoreDemo.Model;

namespace Session3EFCoreDemo
{
    internal class Program
    {
        static void Main()
        {
            #region Loading Navigational Properties
            //using AppDbContext context = new AppDbContext();

            ////var department = new List<Department>()
            ////{
            ////    new Department() {Name="HR"},
            ////    new Department() {Name="PR"},
            ////    new Department() {Name="IT"},
            ////};

            ////var employee = new List<Employee>()
            ////{
            ////    new Employee() {Name ="Noura",Address="Cairo",Age=22,Salary=19000,DeptId=100},
            ////    new Employee() {Name ="Dina",Address="Giza",Age=26,Salary=23000,DeptId=100},
            ////    new Employee() {Name ="Mariam",Address="Alex",Age=19,Salary=20000,DeptId=200},
            ////    new Employee() {Name ="Ahmed",Address="Cairo",Age=27,Salary=12000,DeptId=200},
            ////    new Employee() {Name ="Omar",Address="Giza",Age=24,Salary=19000,DeptId=100},
            ////    new Employee() {Name ="Malak",Address="Cairo",Age=29,Salary=11000,DeptId=300},
            ////    new Employee() {Name ="Mahmoud",Address="Alex",Age=24,Salary=14000,DeptId=300},
            ////};

            ////context.Departments.AddRange(department);
            ////context.Employees.AddRange(employee);

            ////context.SaveChanges();

            ////var employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            ////Console.WriteLine(employee?.Id ?? 0);
            ////Console.WriteLine(employee?.Name ?? "NA");
            ////Console.WriteLine(employee?.Address ?? "NA");
            ////Console.WriteLine(employee?.Salary ?? 0.0f);
            ////Console.WriteLine(employee?.Age ?? 0);
            ////Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(employee?.DeptId ?? 0);
            ////Console.WriteLine(employee?.WorkFor.Name ?? "NA");


            ////var department = context.Departments.FirstOrDefault(D=>D.Id == 100);

            ////Console.WriteLine(department.Name);

            ////foreach (var item in department.Employees)
            ////{
            ////    Console.WriteLine(item.Name);
            ////}

            ////NOTE : EFCore don't Load any Navigatial property

            ////EFCore Loading Navigatial property
            ////1.Explicit Loading
            ////2.Eager Loading
            ////3.Lazy Loading

            //#region Explicit Loading
            ////1.Explicit Loading
            ////var employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            //////context.Entry(employee).Reference("WorkFor").Load(); //Explicit Loading
            //////context.Entry(employee).Reference(nameof(Employee.WorkFor)).Load(); //Explicit Loading
            ////context.Entry(employee).Reference(E=>E.WorkFor).Load(); //Explicit Loading

            ////Console.WriteLine(employee?.Id ?? 0);
            ////Console.WriteLine(employee?.Name ?? "NA");
            ////Console.WriteLine(employee?.Address ?? "NA");
            ////Console.WriteLine(employee?.Salary ?? 0.0f);
            ////Console.WriteLine(employee?.Age ?? 0);
            ////Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(employee?.DeptId ?? 0);
            ////Console.WriteLine(employee?.WorkFor.Name ?? "NA");


            ////var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            ////context.Entry(department).Collection(D=>D.Employees).Load(); //Explicit Loading

            ////Console.WriteLine(department.Name);

            ////foreach (var item in department.Employees)
            ////{
            ////    Console.WriteLine(item.Name);
            ////} 
            //#endregion

            //#region Eager Loading
            ////2.Eager Loading

            ////var employee = context.Employees.Include(E=>E.WorkFor).FirstOrDefault(E => E.Id == 10);


            ////Console.WriteLine(employee?.Id ?? 0);
            ////Console.WriteLine(employee?.Name ?? "NA");
            ////Console.WriteLine(employee?.Address ?? "NA");
            ////Console.WriteLine(employee?.Salary ?? 0.0f);
            ////Console.WriteLine(employee?.Age ?? 0);
            ////Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(employee?.DeptId ?? 0);
            ////Console.WriteLine(employee?.WorkFor.Name ?? "NA");


            ////var department = context.Departments.Include(E=>E.Employees).FirstOrDefault(D => D.Id == 100);

            ////Console.WriteLine(department.Name);

            ////foreach (var item in department.Employees)
            ////{
            ////    Console.WriteLine(item.Name);
            ////} 
            //#endregion

            //#region Lazy Loading
            ////3.Lazy Loading 
            ////3.1. Install Package Proxies
            ////3.2. Update OnConfiguraing(), UseLazyLoadingProxies
            ////3.3. Make all entities Public
            ////3.4  Make all Navigational Properties virtual 


            ////var employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            ////Console.WriteLine(employee?.Id ?? 0);
            ////Console.WriteLine(employee?.Name ?? "NA");
            ////Console.WriteLine(employee?.Address ?? "NA");
            ////Console.WriteLine(employee?.Salary ?? 0.0f);
            ////Console.WriteLine(employee?.Age ?? 0);
            ////Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(employee?.DeptId ?? 0);
            ////Console.WriteLine(employee?.WorkFor.Name ?? "NA");


            ////var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            ////Console.WriteLine(department.Name);

            ////foreach (var item in department.Employees)
            ////{
            ////    Console.WriteLine(item.Name);
            ////} 
            //#endregion 
            #endregion

            #region Join
            // //Join Operators- Join inner

            // /*
            //  Select E.Id , E.Name , D.Id , D.Name
            // From Employee E ,Department D
            // Where PK = 
            //  */

            //using AppDbContext context = new AppDbContext();

            // var result = context.Employees.Join(context.Departments, E => E.DeptId, D => D.Id, (E, D) => new
            // {
            //     EmpId = E.Id,
            //     EmpName = E.Name,
            //     DeptId = D.Id,
            //     DeptName =D.Name
            // }).Where(D=>D.DeptName=="HR");

            // //Query Expression 

            // result = from E in context.Employees
            //          join D in context.Departments
            //          on E.DeptId equals D.Id
            //          select new
            //          {
            //              EmpId = E.Id,
            //              EmpName = E.Name,
            //              DeptId = D.Id,
            //              DeptName = D.Name
            //          };

            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion

            #region Tracking vs NoTracking
            ////Tracking vs NoTracking

            //using AppDbContext context = new AppDbContext();

            //var result = context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(context.Entry(result).State); //Unchanged

            //result.Name = "Amr"; //Local

            //Console.WriteLine(context.Entry(result).State); //Modified

            //Console.WriteLine(result.Name);

            //context.SaveChanges(); //Remotly 
            #endregion

            #region Local vs Remote
            ////Local vs Remote 

            //using AppDbContext context = new AppDbContext();


            //////Remotly
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();

            ////context.Employees.Load();

            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any();
            ////context.Employees.Local.Any(); 
            #endregion

            //View 
            using AppDbContext context = new AppDbContext();

            var result = context.departmentManagers.FromSqlRaw("Select * From DepartmentManagersView");

            foreach (var item in result)
            {
                Console.WriteLine(item.DeptName);
            }
        }
    }
}
