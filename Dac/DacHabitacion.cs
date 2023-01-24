using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Data;

namespace Dac
{
    public class DacHabitacion
    {
        private static DBClinicasContext context = new DBClinicasContext();
        public static List<Habitacion> Select()
        {
            return context.Habitaciones.ToList();
        }
        public static List<Habitacion> Select(string Estado)
        {
            //TODO
            return null;
        }
        public static int Insert(Habitacion habitacion)
        {
            context.Habitaciones.Add(habitacion);

            return context.SaveChanges();
        }

        public static Habitacion SelectById(int nro)
        {
            return context.Habitaciones.Find(nro);
        }
        public static int Eliminar(int id)
        {
            Habitacion habitacionOrigen = context.Habitaciones.Find(id);
            if (habitacionOrigen!=null)
            {
                context.Habitaciones.Remove(habitacionOrigen);
                return context.SaveChanges();
            }

            return 0;
        }

    }
}
