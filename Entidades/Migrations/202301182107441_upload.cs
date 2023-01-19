namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upload : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enfermeros", "Cuil", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enfermeros", "Cuil", c => c.Int(nullable: false));
        }
    }
}
