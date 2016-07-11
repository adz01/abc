namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnotherMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("HR.Employee", "LevelId", c => c.Long());
            AddColumn("HR.Employee", "GenderId", c => c.Long());
            CreateIndex("HR.Employee", "LevelId");
            CreateIndex("HR.Employee", "GenderId");
            AddForeignKey("HR.Employee", "GenderId", "Nom.Gender", "GenderId");
            AddForeignKey("HR.Employee", "LevelId", "Nom.Level", "LevelId");
        }
        
        public override void Down()
        {
            DropForeignKey("HR.Employee", "LevelId", "Nom.Level");
            DropForeignKey("HR.Employee", "GenderId", "Nom.Gender");
            DropIndex("HR.Employee", new[] { "GenderId" });
            DropIndex("HR.Employee", new[] { "LevelId" });
            DropColumn("HR.Employee", "GenderId");
            DropColumn("HR.Employee", "LevelId");
        }
    }
}
