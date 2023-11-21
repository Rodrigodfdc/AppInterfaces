using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Pantallas
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }






        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

            cargarEmpleados();
            mostrarEmpleado(Empleado.listadoEmpleado);


        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /*----------------------------------------------------------------------------------------------------------------------------------*/

        // Los estoy creando aqui, luego los tengo que mover.


        //Añado el proyecto en List de empleados
        private void cargarEmpleados()

        {
            Empleado.listadoEmpleado.Add(new Empleado("My Id", "55386478C", "Rodrigo", "D. Freitas", "D.Cruz", "jefe", "622084620", "rodrigodfdc1995@gmial.com", new DateTime(1995, 11, 13), "5554785", " holaaaa"));

        }

        private void crearCheckboxEmpleado(Empleado empleado)
        {

            System.Windows.Forms.CheckBox checkboxEmpleado = new System.Windows.Forms.CheckBox();
            checkboxEmpleado.AutoSize = true;
            checkboxEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkboxEmpleado.Location = new System.Drawing.Point(75, this.posicionInicialEmpleado);
            checkboxEmpleado.Name = "checkboxPro" + this.contadorEmpleado;
            checkboxEmpleado.Size = new System.Drawing.Size(291, 20);
            checkboxEmpleado.TabIndex = 1;
            checkboxEmpleado.Text = empleado.Apellido1;
            groupBoxEmp.Controls.Add(checkboxEmpleado);

            this.posicionInicialEmpleado += 20;
            this.contadorEmpleado++;

        }


        //Uso un For each para recorrer el 

        public int posicionInicialEmpleado;
        public int contadorEmpleado;


        private void mostrarEmpleado(List<Empleado> ListadoEmpleados)
        {
            this.contadorEmpleado = 1;
            this.posicionInicialEmpleado = 15;

            ListadoEmpleados.ForEach(crearCheckboxEmpleado);

        }



    }
}
