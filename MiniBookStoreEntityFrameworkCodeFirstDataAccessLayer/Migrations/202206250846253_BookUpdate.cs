namespace MiniBookStoreEntityFrameworkCodeFirstDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "ISBN", c => c.String(nullable: false, maxLength: 5));
            CreateIndex("dbo.Books", "ISBN", unique: true);
            DropColumn("dbo.Books", "Deneme");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Deneme", c => c.Int(nullable: false));
            DropIndex("dbo.Books", new[] { "ISBN" });
            AlterColumn("dbo.Books", "ISBN", c => c.String());
        }
    }
}
