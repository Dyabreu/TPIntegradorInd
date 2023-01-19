using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace WindowsPaciente
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            MostrarTodo();
        }

            private void MostrarTodo()
            {
                gridPaciente.DataSource = AdmPaciente.ListarTodo();
            }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Enfermero enfermero = new Enfermero();
            { enfermero.Nombre = "Raul"; enfermero.Apellido = "Montez"; enfermero.Telefono = "492209132"; enfermero.Email = "raulmontez@gmail.com"; enfermero.Domicilio = "CABA"; enfermero.Cuil = "24-32929-2002"; }
            Medico medico = new Medico();
            { medico.Nombre = "Sebastian"; medico.Apellido = "Roro"; medico.Telefono = "9139392"; medico.Email = "sebastian@gmail.com"; medico.Domicilio = "Merlo"; medico.Matricula = "29392D"; medico.Especialidad = "Obstetra"; }
            Habitacion habitacion = new Habitacion();
            { habitacion.Numero = 12345; habitacion.Estado = "Ocupada"; }

            Paciente paciente = new Paciente()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                NroHistoriaClinica = Convert.ToInt32(txtNroHC.Text),
                Enfermero = enfermero,
                Habitacion = habitacion,
                Medico = medico
            };

            int filasAfectadas = AdmPaciente.Insertar(paciente);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
                MostrarTodo();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Enfermero enfermero2 = new Enfermero();
            { enfermero2.Nombre = "Raul"; enfermero2.Apellido = "Montez"; enfermero2.Telefono = "492209132"; enfermero2.Email = "raulmontez@gmail.com"; enfermero2.Domicilio = "CABA"; enfermero2.Cuil = "24-32929-2002"; }
            Medico medico2 = new Medico();
            { medico2.Nombre = "Sebastian"; medico2.Apellido = "Roro"; medico2.Telefono = "9139392"; medico2.Email = "sebastian@gmail.com"; medico2.Domicilio = "Merlo"; medico2.Matricula = "29392D"; medico2.Especialidad = "Obstetra"; }
            Habitacion habitacion2 = new Habitacion();
            { habitacion2.Numero = 12345; habitacion2.Estado = "Ocupada"; }

            Paciente paciente = new Paciente()
            {
                Id = Convert.ToInt32(txtId.Text),
                NroHistoriaClinica = Convert.ToInt32(txtNroHC.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                Enfermero = enfermero2,
                Habitacion = habitacion2,
                Medico = medico2
            };

            int filasAfectadas = AdmPaciente.Eliminar(paciente.Id);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarTodo();
            }

        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Paciente paciente = AdmPaciente.TraerUno(id);
            MessageBox.Show(paciente.Nombre + " " + paciente.Apellido + ". Número de historia clínica: " + paciente.NroHistoriaClinica);
        }
    }
}
