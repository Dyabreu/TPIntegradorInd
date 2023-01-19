using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace Entidades.Data
{
    public class DBClinicasContext : DbContext
    {
        public DBClinicasContext() : base("KeyDB") { }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Director> Directores { get; set; }
        public DbSet<Enfermero> Enfermeros { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
