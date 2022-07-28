namespace Jadhav.Question2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesmade : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "AddedDateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "AddedDateDate", c => c.DateTime());
        }
    }
}
