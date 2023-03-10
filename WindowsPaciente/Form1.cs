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
 

            Paciente paciente = new Paciente()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                NroHistoriaClinica = Convert.ToInt32(txtNroHC.Text),

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
  

            Paciente paciente = new Paciente()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                NroHistoriaClinica = Convert.ToInt32(txtNroHC.Text),
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
