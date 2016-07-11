namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Numaistiuceamfacut : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Nom.Level",
                c => new
                    {
                        LevelId = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.LevelId);
            
        }
        
        public override void Down()
        {
            DropTable("Nom.Level");
        }
    }
}
