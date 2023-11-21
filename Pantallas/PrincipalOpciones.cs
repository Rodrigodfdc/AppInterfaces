using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Pantallas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class PrincipalOpciones : Form
    {
        public PrincipalOpciones()
        {
            InitializeComponent();
        }

        private void cargarProyectos()
        {
            Proyecto.listadoProyectos.Add(new Proyecto("Proyecto5", "WEB 1.0 PARA TÉCNICAS REUNIDAS", new DateTime(2023, 5, 5), new DateTime(2023, 5, 5), Proyecto.Estado.preparado, 500.00, 600.00, false, 222));
            Proyecto.listadoProyectos.Add(new Proyecto("Proyecto4", "APLICACIÓN CONTABLE PARA TÉCNICAS REUNIDAS", new DateTime(2023, 5, 5), new DateTime(2023, 5, 5), Proyecto.Estado.preparado, 500.00, 600.00, false, 222));
            Proyecto.listadoProyectos.Add(new Proyecto("Proyecto3", "WEB 1.0 PARA AXA", new DateTime(2023, 9, 10), new DateTime(2023, 11, 12), Proyecto.Estado.preparado, 1000.00, 1100.00, false, 222));
            Proyecto.listadoProyectos.Add(new Proyecto("Proyecto2", "WEB 3.0 PARA SANTANDER", new DateTime(2023, 5, 5), new DateTime(2023, 5, 5), Proyecto.Estado.preparado, 500.00, 600.00, false, 222));
            Proyecto.listadoProyectos.Add(new Proyecto("Proyecto1", "APLICACION MOVIL SELENIUM", new DateTime(2023, 5, 5), new DateTime(2023, 5, 5), Proyecto.Estado.preparado, 500.00, 600.00, false, 222));

        }


        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoProyectos menu = new ListadoProyectos();
            menu.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            cargarProyectos();

        }

     
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?", "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }

            else
            {
                e.Cancel = false;

            }

        }


        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            registroproyecto menu = new registroproyecto();
            menu.ShowDialog();

        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmNuevoEmpleado menu = new FrmNuevoEmpleado();
            menu.ShowDialog();


        }

        private void listadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEmpleados menu = new FrmEmpleados();
            menu.ShowDialog();
        }

       


    }
}
