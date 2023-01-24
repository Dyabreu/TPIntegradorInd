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
                        Director_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Directores", t => t.Director_Id)
                .Index(t => t.Director_Id);
            
            CreateTable(
                "dbo.Directores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostGrado = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(maxLength: 50, unicode: false),
                        Domicilio = c.String(maxLength: 100, unicode: false),
                        Telefono = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enfermeros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cuil = c.String(),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(maxLength: 50, unicode: false),
                        Domicilio = c.String(maxLength: 100, unicode: false),
                        Telefono = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricula = c.String(maxLength: 50, unicode: false),
                        Especialidad = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(maxLength: 50, unicode: false),
                        Domicilio = c.String(maxLength: 100, unicode: false),
                        Telefono = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NroHistoriaClinica = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(maxLength: 50, unicode: false),
                        Domicilio = c.String(maxLength: 100, unicode: false),
                        Telefono = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clinicas", "Director_Id", "dbo.Directores");
            DropIndex("dbo.Clinicas", new[] { "Director_Id" });
            DropTable("dbo.Pacientes");
            DropTable("dbo.Medicos");
            DropTable("dbo.Habitaciones");
            DropTable("dbo.Enfermeros");
            DropTable("dbo.Directores");
            DropTable("dbo.Clinicas");
        }
    }
}
