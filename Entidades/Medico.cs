using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Data;
using Entidades.BASE;

namespace Entidades
{
    [Table("Medicos")]
    public class Medico : Persona
    {
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Matricula { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Especialidad { get; set; }
        public List<Paciente> Pacientes { get; set; }

    }
}

