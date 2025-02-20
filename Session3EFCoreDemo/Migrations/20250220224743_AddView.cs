using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session3EFCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create Or Alter View DepartmentManagersView
                                as
	                                Select E.Id as EmpId , E.Name as EmpName  , D.Id as DeptId , D.Name as DeptName
	                                From Employees e , Departments D 
	                                Where E.Id= D.ManagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drop View DepartmentManagersView");
        }
    }
}
