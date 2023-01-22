using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;


namespace WindowsHabitacion
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
        private void MostrarTodo()
        {
            gridHabitacion.DataSource = AdmHabitacion.ListarTodo();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Habitacion habitacion = new Habitacion()
            {
                Numero = Convert.ToInt32(txtNumero.Text),
                Estado= txtEstado.Text

            };

            int filasAfectadas = AdmHabitacion.Insertar(habitacion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
                MostrarTodo();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*Director director = new Director()
            {
                Nombre = "Cole",
                Apellido = "Perez",
                Telefono = "9213923129",
                Email = "cole@gmail.com",
                Domicilio = "Buenos Aires",
                PostGrado = "Clinica",
            };

            Clinica clinica = new Clinica()
            {
                Nombre = "SantaAlgo",
                Domicilio = "Buenos Aires",
                Telefono = "139129319321",
                Email = "santa@gmail.com",
                Director = director,
            };*/

            Habitacion habitacion = new Habitacion()
            {
                Id = Convert.ToInt32(txtId.Text),
                Numero = Convert.ToInt32(txtNumero.Text),
                Estado = txtEstado.Text,
            };


            int filasAfectadas = AdmHabitacion.Eliminar(habitacion.Id);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarTodo();
            }

        }


        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Habitacion habitacion = AdmHabitacion.TraerUno(id);
            MessageBox.Show("Habitacion número " + habitacion.Numero + " " + habitacion.Estado + ".");

        }


    }
}
