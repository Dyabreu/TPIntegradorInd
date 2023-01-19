using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dac;
using Entidades;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            List<Habitacion> listaHabitacion = new List<Habitacion>();

            listaHabitacion.Add(new Habitacion() { Id = 1, Numero = 1, Estado = "Ocupado" });
            listaHabitacion.Add(new Habitacion() { Id = 2, Numero = 2, Estado = "Libre" });
            listaHabitacion.Add(new Habitacion() { Id = 3, Numero = 3, Estado = "Libre" });
            listaHabitacion.Add(new Habitacion() { Id = 4, Numero = 4, Estado = "Ocupado" });
            listaHabitacion.Add(new Habitacion() { Id = 5, Numero = 5, Estado = "Libre" });

            return listaHabitacion;
        }

        public static List<Habitacion> ListarTodo()
        {

            return DacHabitacion.Select();
        }
        public static List<Habitacion> Listar(int Estado)
        {
            //TODO…Seleccionar codigo para listar por Estado
            return null;
        }
        public static int Insertar(Habitacion habitacion)
        {
            return DacHabitacion.Insert(habitacion);
        }

        public static int Eliminar(int id)
        {
            return DacHabitacion.Eliminar(id);

        }

        public static Habitacion TraerUno(int nroHabitacion)
        {
            return DacHabitacion.SelectById(nroHabitacion);

        }
    }
}
