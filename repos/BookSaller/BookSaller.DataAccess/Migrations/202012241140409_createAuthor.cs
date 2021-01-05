namespace BookSaller.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createAuthor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            AddColumn("dbo.Books", "Author_AuthorID", c => c.Int());
            CreateIndex("dbo.Books", "Author_AuthorID");
            AddForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors", "AuthorID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_AuthorID" });
            DropColumn("dbo.Books", "Author_AuthorID");
            DropTable("dbo.Authors");
        }
    }
}
