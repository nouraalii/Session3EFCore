using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session3EFCoreDemo.Model;

namespace Session3EFCoreDemo.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<DepartmentManager>().ToView("DepartmentManagersView").HasNoKey();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server =. ; Database = DemoEFS3 ; Trusted_Connection = True ; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<DepartmentManager> departmentManagers { get; set; }
    }
}
