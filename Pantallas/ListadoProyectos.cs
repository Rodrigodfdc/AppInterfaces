using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class ListadoProyectos : Form
    {
        public ListadoProyectos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            mostrarProyectos(Proyecto.listadoProyectos);

        }


        private void mostrarProyectos(List<Proyecto> listadoProyectos)
        {
            this.contadorNombre = 1;
            this.posicionInicial = 15;
            listadoProyectos.ForEach(crearCheckbox);
           // listadoProyectos.ForEach(crearEtiqueta);
        }

        public int posicionInicial;
        public int contadorNombre;








     //Método para crear etiquetas, parece CSS no me mola nada
     //    private void crearEtiqueta(Proyecto proyecto)
     //   {

        // Label LblProyecto = new
        //System.Windows.Forms.Label();
        //LblProyecto.AutoSize = true;
        //LblProyecto.Font = new
        //System.Drawing.Font("Microsoft Sans Serif", 12F,
        //System.Drawing.FontStyle.Regular,
        //System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //LblProyecto.Location = new
        //System.Drawing.Point(75, posicionInicial /*posicion*/);
        //LblProyecto.Name = "lblProyecto"
        //+contadorNombre;
        //LblProyecto.Size = new System.Drawing.Size(291,20);
        //LblProyecto.TabIndex = 1;
        //LblProyecto.Text = proyecto.Descripcion1;
        //groupBox1.Controls.Add(LblProyecto);

        //this.posicionInicial += 20;
        //this.contadorNombre++;

    //   }
   



    private void crearCheckbox(Proyecto proyecto)
        {

            System.Windows.Forms.CheckBox checkboxProyecto = new System.Windows.Forms.CheckBox();
            checkboxProyecto.AutoSize = true;
            checkboxProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkboxProyecto.Location = new System.Drawing.Point(75, this.posicionInicial);
            checkboxProyecto.Name = "checkboxPro" + this.contadorNombre;
            checkboxProyecto.Size = new System.Drawing.Size(291, 20);
            checkboxProyecto.TabIndex = 1;
            checkboxProyecto.Text = proyecto.Descripcion1;
            groupBox1.Controls.Add(checkboxProyecto);

            this.posicionInicial += 20;
            this.contadorNombre++;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.groupBox1.Controls.Clear();
        }

        private void ordenarProyecto(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Clear();
            Proyecto.listadoProyectos = Proyecto.listadoProyectos.OrderBy(proyecto => proyecto.Codigo1).ToList();
            mostrarProyectos(Proyecto.listadoProyectos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Clear();
            Proyecto.listadoProyectos = Proyecto.listadoProyectos.OrderBy(proyecto => proyecto.Descripcion1).ToList();
            mostrarProyectos(Proyecto.listadoProyectos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
              this.groupBox1.Controls.Clear();
              Proyecto.listadoProyectos = Proyecto.listadoProyectos.OrderBy(proyecto => proyecto.Fecha_inicio1).ToList();
              mostrarProyectos(Proyecto.listadoProyectos);
             

        }


        // Imprimir, lo voy a dejar comentado porque la funcion la me´ti directamente en el boton de eliminar proyecto

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Clear();
            mostrarProyectos(Proyecto.listadoProyectos);

        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {

                // Verifica si el control es un CheckBox
                if (c is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox checkbox1 = (System.Windows.Forms.CheckBox)c;

                    if (checkbox1.Checked)
                    {

                        int posicion = Proyecto.listadoProyectos.FindIndex((Proyecto proyecto) => proyecto.Descripcion1 == checkbox1.Text);
                        if (posicion != -1)
                        {
                            Proyecto.listadoProyectos.RemoveAt(posicion);

                        }
                    }

                }
            }


         // Simplemente para que se vaya viendo como se elimina 1 a 1
         this.groupBox1.Controls.Clear();
         mostrarProyectos(Proyecto.listadoProyectos);


        }
        // Boton cancelar
        private void button3_Click(object sender, EventArgs e)
        {

            this.groupBox1.Controls.Clear();
            mostrarProyectos(Proyecto.listadoProyectos);

        }
    }
}




