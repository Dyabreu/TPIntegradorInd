namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class telefonostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Directores", "Telefono", c => c.String());
            AlterColumn("dbo.Pacientes", "Telefono", c => c.String());
            AlterColumn("dbo.Enfermeros", "Telefono", c => c.String());
            AlterColumn("dbo.Medicos", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Medicos", "Telefono", c => c.Int(nullable: false));
            AlterColumn("dbo.Enfermeros", "Telefono", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacientes", "Telefono", c => c.Int(nullable: false));
            AlterColumn("dbo.Directores", "Telefono", c => c.Int(nullable: false));
        }
    }
}
