namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idchanges : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Clinicas", new[] { "Director_ID" });
            DropIndex("dbo.Pacientes", new[] { "Enfermero_ID" });
            DropIndex("dbo.Pacientes", new[] { "Medico_ID" });
            AlterColumn("dbo.Medicos", "Especialidad", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.Clinicas", "Director_Id");
            CreateIndex("dbo.Pacientes", "Enfermero_Id");
            CreateIndex("dbo.Pacientes", "Medico_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Pacientes", new[] { "Medico_Id" });
            DropIndex("dbo.Pacientes", new[] { "Enfermero_Id" });
            DropIndex("dbo.Clinicas", new[] { "Director_Id" });
            AlterColumn("dbo.Medicos", "Especialidad", c => c.String(maxLength: 50, unicode: false));
            CreateIndex("dbo.Pacientes", "Medico_ID");
            CreateIndex("dbo.Pacientes", "Enfermero_ID");
            CreateIndex("dbo.Clinicas", "Director_ID");
        }
    }
}
