using Dac;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {

            List<Paciente> listaPacientes = new List<Paciente>();


            listaPacientes.Add(new Paciente() { Id = 1, Nombre = "Juana", Apellido = "Perez", Domicilio = "CABA", Email = "juana@gmail.com", NroHistoriaClinica = 001, Telefono = "1134345656" });
            listaPacientes.Add(new Paciente() { Id = 2, Nombre = "Matias", Apellido = "Gonzalez", Domicilio = "Rosario", Email = "mati@gmail.com", NroHistoriaClinica = 002, Telefono = "1156567878" });
            listaPacientes.Add(new Paciente() { Id = 3, Nombre = "Ana", Apellido = "Perez", Domicilio = "CABA", Email = "ana@hotmail.com", NroHistoriaClinica = 003, Telefono = "1178789966" });
            listaPacientes.Add(new Paciente() { Id = 4, Nombre = "Lucia", Apellido = "Ramirez", Domicilio = "Cordoba", Email = "luci@gmail.com", NroHistoriaClinica = 004, Telefono = "1123557878" });
            listaPacientes.Add(new Paciente() { Id = 5, Nombre = "Pablo", Apellido = "Fernadez", Domicilio = "Entre Rios", Email = "pablito@gmail.com", NroHistoriaClinica = 005, Telefono = "1145897676" });

            return listaPacientes;
        }

        public static List<Paciente> ListarTodo()
        {

            return DacPaciente.Select();
        }
        public static int Insertar(Paciente paciente)
        {
            return DacPaciente.Insert(paciente);
        }
        public static int Eliminar(int id)
        {
            return DacPaciente.Eliminar(id);
        }
        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            return DacPaciente.SelectById(nroHistoriaClinica);
        }

    }
}
