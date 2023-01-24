namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clinicas", newName: "Clinica");
            DropForeignKey("dbo.Habitaciones", "ClinicaId", "dbo.Clinicas");
            DropForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones");
            DropForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros");
            DropForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos");
            DropIndex("dbo.Habitaciones", new[] { "ClinicaId" });
            DropIndex("dbo.Pacientes", new[] { "EnfermeroId" });
            DropIndex("dbo.Pacientes", new[] { "MedicoId" });
            DropIndex("dbo.Pacientes", new[] { "HabitacionId" });
            AlterColumn("dbo.Habitaciones", "ClinicaId", c => c.Int());
            AlterColumn("dbo.Pacientes", "EnfermeroId", c => c.Int());
            AlterColumn("dbo.Pacientes", "MedicoId", c => c.Int());
            AlterColumn("dbo.Pacientes", "HabitacionId", c => c.Int());
            CreateIndex("dbo.Habitaciones", "ClinicaId");
            CreateIndex("dbo.Pacientes", "EnfermeroId");
            CreateIndex("dbo.Pacientes", "MedicoId");
            CreateIndex("dbo.Pacientes", "HabitacionId");
            AddForeignKey("dbo.Habitaciones", "ClinicaId", "dbo.Clinica", "Id");
            AddForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones", "Id");
            AddForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros", "Id");
            AddForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos");
            DropForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros");
            DropForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones");
            DropForeignKey("dbo.Habitaciones", "ClinicaId", "dbo.Clinica");
            DropIndex("dbo.Pacientes", new[] { "HabitacionId" });
            DropIndex("dbo.Pacientes", new[] { "MedicoId" });
            DropIndex("dbo.Pacientes", new[] { "EnfermeroId" });
            DropIndex("dbo.Habitaciones", new[] { "ClinicaId" });
            AlterColumn("dbo.Pacientes", "HabitacionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacientes", "MedicoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacientes", "EnfermeroId", c => c.Int(nullable: false));
            AlterColumn("dbo.Habitaciones", "ClinicaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pacientes", "HabitacionId");
            CreateIndex("dbo.Pacientes", "MedicoId");
            CreateIndex("dbo.Pacientes", "EnfermeroId");
            CreateIndex("dbo.Habitaciones", "ClinicaId");
            AddForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Habitaciones", "ClinicaId", "dbo.Clinicas", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Clinica", newName: "Clinicas");
        }
    }
}
