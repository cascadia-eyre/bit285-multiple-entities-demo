namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeSomeBookChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FirstBook = c.String(),
                        Birthyear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            AddColumn("dbo.Members", "Birthyear", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "AuthorID");
            AddForeignKey("dbo.Books", "AuthorID", "dbo.Authors", "AuthorID", cascadeDelete: true);
            DropColumn("dbo.Members", "Birthday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "Birthday", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropColumn("dbo.Members", "Birthyear");
            DropTable("dbo.Authors");
        }
    }
}
