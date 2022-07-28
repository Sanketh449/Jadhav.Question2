namespace Jadhav.Question2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedname : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        ISBN = c.String(nullable: false),
                        BookName = c.String(nullable: false),
                        Genre = c.String(nullable: false),
                        AuthorName = c.String(nullable: false),
                        PublishedDate = c.DateTime(nullable: false),
                        AddedDateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
