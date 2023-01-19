namespace Entidades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _try : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones");
            DropForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros");
            DropForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos");
            DropIndex("dbo.Pacientes", new[] { "EnfermeroId" });
            DropIndex("dbo.Pacientes", new[] { "MedicoId" });
            DropIndex("dbo.Pacientes", new[] { "HabitacionId" });
            RenameColumn(table: "dbo.Pacientes", name: "HabitacionId", newName: "Habitacion_Id");
            RenameColumn(table: "dbo.Pacientes", name: "EnfermeroId", newName: "Enfermero_Id");
            RenameColumn(table: "dbo.Pacientes", name: "MedicoId", newName: "Medico_Id");
            AlterColumn("dbo.Pacientes", "Enfermero_Id", c => c.Int());
            AlterColumn("dbo.Pacientes", "Medico_Id", c => c.Int());
            AlterColumn("dbo.Pacientes", "Habitacion_Id", c => c.Int());
            CreateIndex("dbo.Pacientes", "Habitacion_Id");
            CreateIndex("dbo.Pacientes", "Enfermero_Id");
            CreateIndex("dbo.Pacientes", "Medico_Id");
            AddForeignKey("dbo.Pacientes", "Habitacion_Id", "dbo.Habitaciones", "Id");
            AddForeignKey("dbo.Pacientes", "Enfermero_Id", "dbo.Enfermeros", "Id");
            AddForeignKey("dbo.Pacientes", "Medico_Id", "dbo.Medicos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "Medico_Id", "dbo.Medicos");
            DropForeignKey("dbo.Pacientes", "Enfermero_Id", "dbo.Enfermeros");
            DropForeignKey("dbo.Pacientes", "Habitacion_Id", "dbo.Habitaciones");
            DropIndex("dbo.Pacientes", new[] { "Medico_Id" });
            DropIndex("dbo.Pacientes", new[] { "Enfermero_Id" });
            DropIndex("dbo.Pacientes", new[] { "Habitacion_Id" });
            AlterColumn("dbo.Pacientes", "Habitacion_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacientes", "Medico_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacientes", "Enfermero_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Pacientes", name: "Medico_Id", newName: "MedicoId");
            RenameColumn(table: "dbo.Pacientes", name: "Enfermero_Id", newName: "EnfermeroId");
            RenameColumn(table: "dbo.Pacientes", name: "Habitacion_Id", newName: "HabitacionId");
            CreateIndex("dbo.Pacientes", "HabitacionId");
            CreateIndex("dbo.Pacientes", "MedicoId");
            CreateIndex("dbo.Pacientes", "EnfermeroId");
            AddForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pacientes", "EnfermeroId", "dbo.Enfermeros", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitaciones", "Id", cascadeDelete: true);
        }
    }
}
