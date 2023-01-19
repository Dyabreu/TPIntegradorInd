namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newbase : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Locas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Locas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
