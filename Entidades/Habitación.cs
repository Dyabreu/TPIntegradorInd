using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Habitaciones")]
    public class Habitacion
    {
        public int Id { get; set; }
        [Required]
        public int Numero { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Estado { get; set; }
        public int? ClinicaId { get; set; }

        [ForeignKey("ClinicaId")]
        public Clinica Clinica { get; set; }

        public List<Paciente> Pacientes { get; set; }

    }
}
