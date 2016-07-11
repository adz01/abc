namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YMCA : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Departments", newName: "Department");
            RenameTable(name: "dbo.Employees", newName: "Employee");
            RenameTable(name: "dbo.Jobs", newName: "Job");
            RenameTable(name: "dbo.Locations", newName: "Location");
            MoveTable(name: "dbo.Department", newSchema: "HR");
            MoveTable(name: "dbo.Employee", newSchema: "HR");
            MoveTable(name: "dbo.Job", newSchema: "HR");
            MoveTable(name: "dbo.Location", newSchema: "HR");
        }
        
        public override void Down()
        {
            MoveTable(name: "HR.Location", newSchema: "dbo");
            MoveTable(name: "HR.Job", newSchema: "dbo");
            MoveTable(name: "HR.Employee", newSchema: "dbo");
            MoveTable(name: "HR.Department", newSchema: "dbo");
            RenameTable(name: "dbo.Location", newName: "Locations");
            RenameTable(name: "dbo.Job", newName: "Jobs");
            RenameTable(name: "dbo.Employee", newName: "Employees");
            RenameTable(name: "dbo.Department", newName: "Departments");
        }
    }
}
