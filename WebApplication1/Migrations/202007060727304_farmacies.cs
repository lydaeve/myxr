namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class farmacies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.farmacies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sucursals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adresss1 = c.String(unicode: false),
                        Adresss2 = c.String(unicode: false),
                        City = c.String(unicode: false),
                        Country = c.String(unicode: false),
                        Departamento = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        ContactName = c.String(unicode: false),
                        StoreId = c.Int(),
                        Farmacies_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.farmacies", t => t.Farmacies_Id)
                .Index(t => t.Farmacies_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sucursals", "Farmacies_Id", "dbo.farmacies");
            DropIndex("dbo.Sucursals", new[] { "Farmacies_Id" });
            DropTable("dbo.Sucursals");
            DropTable("dbo.farmacies");
        }
    }
}
