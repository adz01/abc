namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("HR.Department", "DepartmentName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("HR.Employee", "LastName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("HR.Employee", "Email", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("HR.Employee", "JobId", c => c.Long(nullable: false));
            AlterColumn("HR.Location", "City", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("HR.Department", "LocationId");
            CreateIndex("HR.Employee", "JobId");
            CreateIndex("HR.Employee", "ManagerId");
            CreateIndex("HR.Employee", "DepartmentId");
            AddForeignKey("HR.Department", "LocationId", "HR.Location", "LocationId");
            AddForeignKey("HR.Employee", "DepartmentId", "HR.Department", "DepartmentId");
            AddForeignKey("HR.Employee", "JobId", "HR.Job", "JobId");
            AddForeignKey("HR.Employee", "ManagerId", "HR.Employee", "EmployeeId");
        }
        
        public override void Down()
        {
            DropForeignKey("HR.Employee", "ManagerId", "HR.Employee");
            DropForeignKey("HR.Employee", "JobId", "HR.Job");
            DropForeignKey("HR.Employee", "DepartmentId", "HR.Department");
            DropForeignKey("HR.Department", "LocationId", "HR.Location");
            DropIndex("HR.Employee", new[] { "DepartmentId" });
            DropIndex("HR.Employee", new[] { "ManagerId" });
            DropIndex("HR.Employee", new[] { "JobId" });
            DropIndex("HR.Department", new[] { "LocationId" });
            AlterColumn("HR.Location", "City", c => c.String(maxLength: 250));
            AlterColumn("HR.Employee", "JobId", c => c.Long());
            AlterColumn("HR.Employee", "Email", c => c.String(maxLength: 250));
            AlterColumn("HR.Employee", "LastName", c => c.String(maxLength: 250));
            AlterColumn("HR.Department", "DepartmentName", c => c.String(maxLength: 250));
        }
    }
}
