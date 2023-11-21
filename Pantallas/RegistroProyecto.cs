using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp3.Proyecto;

namespace WindowsFormsApp3
{
    public partial class registroproyecto : Form
    {
        public registroproyecto()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       // public static List<Proyecto> listadoProyectos = new List<Proyecto>();

        public Estado devolverEstado(string estado)
        {
            if (estado.Equals("nuevo"))
            {
                return Estado.nuevo;
            }
            if (estado.Equals("ejecutado"))
            {
                return Estado.ejecutado;

            }
            if (estado.Equals("bloqueado"))
            {
                return Estado.bloqueado;
            }

            return Estado.finalizado;

        } 


        public bool devolverCambios(object cambios)
        {

            string cambio = Convert.ToString(cambios).ToLower();
            
            if (cambio.Equals("si"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // cambiar del objeto del enum a string
            string estadoCadena = Convert.ToString(textCambios);
            Estado estado = devolverEstado(estadoCadena);

            Proyecto newProyecto = new Proyecto(textCodigo.Text, textDescripcion.Text, textFechaInicio.Value, textFechaFin.Value, estado, int.Parse(textPresupuestoInicial.Text), int.Parse(textPresupuestoActual.Text), devolverCambios(textCambios.Text), int.Parse(textCodigoCliente.Text)); 

            Proyecto.listadoProyectos.Add(newProyecto);

            textCodigo.Clear();
            textDescripcion.Clear();
            textFechaInicio.Controls.Clear();
            textFechaFin.Controls.Clear();
            textEstadoProyecto.Controls.Clear();
            textPresupuestoInicial.Clear();
            textPresupuestoActual.Clear();
            textCambios.Clear();
            textCodigoCliente.Clear();



            MessageBox.Show("El proyecto ha sido añadido con éxito :)");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nuevoproyecto_Load(object sender, EventArgs e)
        {

        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textCodigoCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
