namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRowVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("HR.Department", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("HR.Employee", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("HR.Job", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("Hr.Project", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("HR.Location", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("HR.Location", "RowVersion");
            DropColumn("Hr.Project", "RowVersion");
            DropColumn("HR.Job", "RowVersion");
            DropColumn("HR.Employee", "RowVersion");
            DropColumn("HR.Department", "RowVersion");
        }
    }
}
