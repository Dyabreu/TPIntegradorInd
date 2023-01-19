using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Negocio;
using Entidades;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            gridPacientes.DataSource = AdmPaciente.Listar();
            gridMedicos.DataSource = AdmMedico.Listar();

            List<Habitacion> listaHabitaciones = AdmHabitacion.Listar();

            foreach (Habitacion habitacion in listaHabitaciones)
            {
                listHabitaciones.Items.Add("Numero Habitacion: " + habitacion.Numero + ", Estado: " + habitacion.Estado);
            }

            List<Medico> listaMedicos = AdmMedico.Listar();

            foreach (Medico medico in listaMedicos)
            {
                if (medico.Especialidad == "Clinico")
                {
                    listMedicos.Items.Add("Medico: " + medico.Nombre + ", Especialidad: " + medico.Especialidad);
                }

            }
        }
    }
}
