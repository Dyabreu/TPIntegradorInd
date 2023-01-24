namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relaciones : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Clinicas", name: "Director_Id", newName: "DirectorId");
            RenameIndex(table: "dbo.Clinicas", name: "IX_Director_Id", newName: "IX_DirectorId");
            AddColumn("dbo.Habitaciones", "ClinicaId", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "EnfermeroId", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "MedicoId", c => c.Int(nullable: false));
            AddColumn("dbo.Pacientes", "HabitacionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Habitaciones", "ClinicaId");
            CreateIndex("dbo.Pacientes", "EnfermeroId");
            CreateIndex("dbo.Pacientes", "MedicoId");
            CreateIndex("dbo.Pacientes", "HabitacionId");
            AddForeignKey("dbo.Habitaciones", "ClinicaId", "dbo.Clinicas", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos");
            DropForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones");
            DropForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros");
            DropForeignKey("dbo.Habitaciones", "ClinicaId", "dbo.Clinicas");
            DropIndex("dbo.Pacientes", new[] { "HabitacionId" });
            DropIndex("dbo.Pacientes", new[] { "MedicoId" });
            DropIndex("dbo.Pacientes", new[] { "EnfermeroId" });
            DropIndex("dbo.Habitaciones", new[] { "ClinicaId" });
            DropColumn("dbo.Pacientes", "HabitacionId");
            DropColumn("dbo.Pacientes", "MedicoId");
            DropColumn("dbo.Pacientes", "EnfermeroId");
            DropColumn("dbo.Habitaciones", "ClinicaId");
            RenameIndex(table: "dbo.Clinicas", name: "IX_DirectorId", newName: "IX_Director_Id");
            RenameColumn(table: "dbo.Clinicas", name: "DirectorId", newName: "Director_Id");
        }
    }
}
