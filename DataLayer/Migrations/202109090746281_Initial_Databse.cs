namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Databse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookComments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        BookID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        WebSite = c.String(),
                        Comment = c.String(nullable: false, maxLength: 150),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .Index(t => t.BookID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        GroupID = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 150),
                        Author = c.String(nullable: false),
                        Publisher = c.String(nullable: false),
                        ShortDescription = c.String(nullable: false),
                        ImageName = c.String(),
                        Visit = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.BookGroups", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.BookGroups",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        GroupTitle = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.GroupID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "GroupID", "dbo.BookGroups");
            DropForeignKey("dbo.BookComments", "BookID", "dbo.Books");
            DropIndex("dbo.Books", new[] { "GroupID" });
            DropIndex("dbo.BookComments", new[] { "BookID" });
            DropTable("dbo.BookGroups");
            DropTable("dbo.Books");
            DropTable("dbo.BookComments");
        }
    }
}
