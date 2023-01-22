using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.BASE;

namespace Entidades
{
    [Table("Enfermeros")]
    public class Enfermero : Persona
    {
        public string Cuil { get; set; }
    }
}

