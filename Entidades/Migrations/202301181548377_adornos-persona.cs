namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adornospersona : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Directores", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Directores", "Apellido", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Directores", "Domicilio", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Directores", "Telefono", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Directores", "Email", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Pacientes", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Pacientes", "Apellido", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Pacientes", "Domicilio", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Pacientes", "Telefono", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Pacientes", "Email", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermeros", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermeros", "Apellido", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermeros", "Domicilio", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Enfermeros", "Telefono", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermeros", "Email", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Medicos", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Medicos", "Apellido", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Medicos", "Domicilio", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Medicos", "Telefono", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Medicos", "Email", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Medicos", "Email", c => c.String());
            AlterColumn("dbo.Medicos", "Telefono", c => c.String());
            AlterColumn("dbo.Medicos", "Domicilio", c => c.String());
            AlterColumn("dbo.Medicos", "Apellido", c => c.String());
            AlterColumn("dbo.Medicos", "Nombre", c => c.String());
            AlterColumn("dbo.Enfermeros", "Email", c => c.String());
            AlterColumn("dbo.Enfermeros", "Telefono", c => c.String());
            AlterColumn("dbo.Enfermeros", "Domicilio", c => c.String());
            AlterColumn("dbo.Enfermeros", "Apellido", c => c.String());
            AlterColumn("dbo.Enfermeros", "Nombre", c => c.String());
            AlterColumn("dbo.Pacientes", "Email", c => c.String());
            AlterColumn("dbo.Pacientes", "Telefono", c => c.String());
            AlterColumn("dbo.Pacientes", "Domicilio", c => c.String());
            AlterColumn("dbo.Pacientes", "Apellido", c => c.String());
            AlterColumn("dbo.Pacientes", "Nombre", c => c.String());
            AlterColumn("dbo.Directores", "Email", c => c.String());
            AlterColumn("dbo.Directores", "Telefono", c => c.String());
            AlterColumn("dbo.Directores", "Domicilio", c => c.String());
            AlterColumn("dbo.Directores", "Apellido", c => c.String());
            AlterColumn("dbo.Directores", "Nombre", c => c.String());
        }
    }
}
