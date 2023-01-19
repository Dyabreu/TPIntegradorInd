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

namespace WindowsMedico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        private void MostrarTodo() { 
        gridMedico.DataSource = AdmMedico.ListarTodo();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTel.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                Matricula = txtMatricula.Text,
                Especialidad = txtEspecialidad.Text

            };

            int filasAfectadas = AdmMedico.Insertar(medico);
            if (filasAfectadas> 0)
            {
                MessageBox.Show("Insert ok");
                MostrarTodo();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTel.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                Matricula = txtMatricula.Text,
                Especialidad = txtEspecialidad.Text

            };

            int filasAfectadas = AdmMedico.Eliminar(medico.Id);
        
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarTodo();
            }

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Medico medico = AdmMedico.TraerUno(id);
            MessageBox.Show(medico.Nombre + " " + medico.Apellido + ". Especialidad: " + medico.Especialidad);
        }
    }
}
