using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Data;
using Entidades;

namespace Dac
{
    public class DacPaciente
    {
        private static DBClinicasContext context = new DBClinicasContext();

        public static List<Paciente> Select()
        {
            return context.Pacientes.ToList();
        }
       
        public static int Insert(Paciente paciente)
        {
            context.Pacientes.Add(paciente);

            return context.SaveChanges();
        }

        public static Paciente SelectById(int id)
        {
            return context.Pacientes.Find(id);
        }
        public static int Eliminar(int id)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(id);
            if (pacienteOrigen!=null)
            {
                context.Pacientes.Remove(pacienteOrigen);
                return context.SaveChanges();
            } 

            return 0;
        }
    }
}

