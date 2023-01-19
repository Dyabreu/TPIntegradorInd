namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pacientes", "Habitacion_Id", "dbo.Habitaciones");
            DropForeignKey("dbo.Pacientes", "Enfermero_Id", "dbo.Enfermeros");
            DropForeignKey("dbo.Pacientes", "Medico_Id", "dbo.Medicos");
            DropIndex("dbo.Pacientes", new[] { "Enfermero_Id" });
            DropIndex("dbo.Pacientes", new[] { "Habitacion_Id" });
            DropIndex("dbo.Pacientes", new[] { "Medico_Id" });
            RenameColumn(table: "dbo.Pacientes", name: "Habitacion_Id", newName: "HabitacionId");
            RenameColumn(table: "dbo.Pacientes", name: "Enfermero_Id", newName: "EnfermeroId");
            RenameColumn(table: "dbo.Pacientes", name: "Medico_Id", newName: "MedicoId");
            AlterColumn("dbo.Pacientes", "EnfermeroId", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacientes", "HabitacionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacientes", "MedicoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pacientes", "EnfermeroId");
            CreateIndex("dbo.Pacientes", "MedicoId");
            CreateIndex("dbo.Pacientes", "HabitacionId");
            AddForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos");
            DropForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros");
            DropForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones");
            DropIndex("dbo.Pacientes", new[] { "HabitacionId" });
            DropIndex("dbo.Pacientes", new[] { "MedicoId" });
            DropIndex("dbo.Pacientes", new[] { "EnfermeroId" });
            AlterColumn("dbo.Pacientes", "MedicoId", c => c.Int());
            AlterColumn("dbo.Pacientes", "HabitacionId", c => c.Int());
            AlterColumn("dbo.Pacientes", "EnfermeroId", c => c.Int());
            RenameColumn(table: "dbo.Pacientes", name: "MedicoId", newName: "Medico_Id");
            RenameColumn(table: "dbo.Pacientes", name: "EnfermeroId", newName: "Enfermero_Id");
            RenameColumn(table: "dbo.Pacientes", name: "HabitacionId", newName: "Habitacion_Id");
            CreateIndex("dbo.Pacientes", "Medico_Id");
            CreateIndex("dbo.Pacientes", "Habitacion_Id");
            CreateIndex("dbo.Pacientes", "Enfermero_Id");
            AddForeignKey("dbo.Pacientes", "Medico_Id", "dbo.Medicos", "Id");
            AddForeignKey("dbo.Pacientes", "Enfermero_Id", "dbo.Enfermeros", "Id");
            AddForeignKey("dbo.Pacientes", "Habitacion_Id", "dbo.Habitaciones", "Id");
        }
    }
}
