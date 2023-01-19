namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(maxLength: 100, unicode: false),
                        Telefono = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 30, unicode: false),
                        Director_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Directores", t => t.Director_ID)
                .Index(t => t.Director_ID);
            
            CreateTable(
                "dbo.Directores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PostGrado = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Habitaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.String(maxLength: 10, unicode: false),
                        Clinica_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinicas", t => t.Clinica_Id)
                .Index(t => t.Clinica_Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NroHistoriaClinica = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.Int(nullable: false),
                        Email = c.String(),
                        Enfermero_ID = c.Int(),
                        Habitacion_Id = c.Int(),
                        Medico_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Enfermeros", t => t.Enfermero_ID)
                .ForeignKey("dbo.Habitaciones", t => t.Habitacion_Id)
                .ForeignKey("dbo.Medicos", t => t.Medico_ID)
                .Index(t => t.Enfermero_ID)
                .Index(t => t.Habitacion_Id)
                .Index(t => t.Medico_ID);
            
            CreateTable(
                "dbo.Enfermeros",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cuil = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Matricula = c.String(maxLength: 50, unicode: false),
                        Especialidad = c.String(maxLength: 50, unicode: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Habitaciones", "Clinica_Id", "dbo.Clinicas");
            DropForeignKey("dbo.Pacientes", "Medico_ID", "dbo.Medicos");
            DropForeignKey("dbo.Pacientes", "Habitacion_Id", "dbo.Habitaciones");
            DropForeignKey("dbo.Pacientes", "Enfermero_ID", "dbo.Enfermeros");
            DropForeignKey("dbo.Clinicas", "Director_ID", "dbo.Directores");
            DropIndex("dbo.Pacientes", new[] { "Medico_ID" });
            DropIndex("dbo.Pacientes", new[] { "Habitacion_Id" });
            DropIndex("dbo.Pacientes", new[] { "Enfermero_ID" });
            DropIndex("dbo.Habitaciones", new[] { "Clinica_Id" });
            DropIndex("dbo.Clinicas", new[] { "Director_ID" });
            DropTable("dbo.Medicos");
            DropTable("dbo.Enfermeros");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Habitaciones");
            DropTable("dbo.Directores");
            DropTable("dbo.Clinicas");
        }
    }
}
