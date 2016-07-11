namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Nom.Gender",
                c => new
                    {
                        GenderId = c.Long(nullable: false, identity: false),
                        Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.GenderId);
            
        }
        
        public override void Down()
        {
            DropTable("Nom.Gender");
        }
    }
}
