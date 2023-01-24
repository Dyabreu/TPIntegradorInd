using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Clinica")]
    public class Clinica
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Domicilio { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Email { get; set; }

        public int? DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Director Director { get; set; }

        public List<Habitacion> Habitaciones { get; set; }


    }
}
