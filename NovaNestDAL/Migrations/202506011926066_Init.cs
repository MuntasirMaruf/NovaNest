namespace NovaNestDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 80, unicode: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 12, unicode: false),
                        Address = c.String(nullable: false, maxLength: 300, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                        Status = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 80, unicode: false),
                        Password = c.String(nullable: false, maxLength: 50, unicode: false),
                        LastLoggedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200, unicode: false),
                        Description = c.String(nullable: false, maxLength: 600, unicode: false),
                        Category = c.Int(nullable: false),
                        Color = c.Int(),
                        Size = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(),
                        Status = c.Int(),
                        Created = c.DateTime(),
                        Updated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Logins");
            DropTable("dbo.Customers");
        }
    }
}
