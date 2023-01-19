using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Data;
using Dac;

namespace Negocio
{
    public static class AdmMedico
    {
        private static DBClinicasContext context = new DBClinicasContext();

        public static List<Medico> Listar()
        {

            List<Medico> medicos = new List<Medico>();

            Medico medico = new Medico()
            {
                Apellido = "Juan",
                Nombre = "Carlos",
                Id = 1,
                Domicilio = "Calle falsa 1",
                Telefono = "123456789",
                Email = "emailfalso@gmail.com",
                Matricula = "000H1",
                Especialidad = "Clinico"
            };
            Medico medico2 = new Medico()
            {
                Apellido = "Juan",
                Nombre = "Carlos II",
                Id = 2,
                Domicilio = "Calle falsa 2",
                Telefono = "123456789",
                Email = "emailfalso2@gmail.com",
                Matricula = "000H2",
                Especialidad = "Traumatologo"
            };
            Medico medico3 = new Medico()
            {
                Apellido = "Juan",
                Nombre = "Carlos III",
                Id = 3,
                Domicilio = "Calle falsa 3",
                Telefono = "123456789",
                Email = "emailfalso3@gmail.com",
                Matricula = "000H3",
                Especialidad = "Clinico"
            };
            Medico medico4 = new Medico()
            {
                Apellido = "Juan",
                Nombre = "Carlos IV",
                Id = 4,
                Domicilio = "Calle falsa 4",
                Telefono = "123456789",
                Email = "emailfalso4@gmail.com",
                Matricula = "000H4",
                Especialidad = "Odontologo"
            };
            Medico medico5 = new Medico()
            {
                Apellido = "Juan",
                Nombre = "Carlos V",
                Id = 5,
                Domicilio = "Calle falsa 5",
                Telefono = "123456789",
                Email = "emailfalso5@gmail.com",
                Matricula = "000H5",
                Especialidad = "Cirujano"
            };

            medicos.Add(medico);
            medicos.Add(medico2);
            medicos.Add(medico3);
            medicos.Add(medico4);
            medicos.Add(medico5);

            return medicos;
        }

        public static List<Medico> ListarTodo()
        {

             return DacMedico.Select();
        }

        public static List<Medico> ListarEspecialidad(string especialidad)
        {

            //TODO Falta logica de ListarEspecialidad para Medico.

            return null;
        }

        public static int Insertar(Medico medico)
        {
           return DacMedico.Insert(medico);
        }

        public static int Eliminar(int id)
        {
            return DacMedico.Eliminar(id);
        }

        public static Medico TraerUno(int id)
        {

            return DacMedico.SelectById(id);

        }

    }
}
