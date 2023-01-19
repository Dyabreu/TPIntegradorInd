using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Data;

namespace Dac
{
    public static class DacMedico
    {   
        private static DBClinicasContext context = new DBClinicasContext();

        public static List<Medico> Select()
        {
            return context.Medicos.ToList();
        }
        public static List<Medico> Select(string Especialidad)
        {
            //TODO
            return null;
        }
    public static int Insert(Medico medico)
        {
            context.Medicos.Add(medico);

            return context.SaveChanges();
        }

        public static Medico SelectById(int id)
        {
            return context.Medicos.Find(id);
        }
        public static int Eliminar(int id)
        {
            Medico medicoOrigen = context.Medicos.Find(id);
            if (medicoOrigen!=null) 
            {
                context.Medicos.Remove(medicoOrigen);
                return context.SaveChanges();
            }
            
            return 0;
        }
    }
}

