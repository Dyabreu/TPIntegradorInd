using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.BASE;

namespace Entidades
{
    [Table("Pacientes")]
    public class Paciente : Persona
    {
        public int NroHistoriaClinica { get; set; }

        #region Propiedades de navegacion 
        #endregion

        public int EnfermeroId { get; set; }

        [ForeignKey("EnfermeroId")]
        public Enfermero Enfermero { get; set; }

        public int MedicoId { get; set; }

        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }

        public int HabitacionId { get; set; }

        [ForeignKey("HabitacionId")]
        public Habitacion Habitacion { get; set; }

    }

}
