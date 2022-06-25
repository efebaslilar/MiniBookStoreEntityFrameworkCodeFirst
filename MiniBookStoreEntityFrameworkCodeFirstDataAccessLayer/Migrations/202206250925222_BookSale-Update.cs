namespace MiniBookStoreEntityFrameworkCodeFirstDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookSaleUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookSales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookSales", "BookId", "dbo.Books");
            DropIndex("dbo.BookSales", new[] { "BookId" });
            DropTable("dbo.BookSales");
        }
    }
}
