namespace MiniBookStoreEntityFrameworkCodeFirstDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookDataUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Stock", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Deneme", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Deneme");
            DropColumn("dbo.Books", "Stock");
        }
    }
}
