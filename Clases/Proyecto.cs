using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    
    public class Proyecto
    {

        public static List<Proyecto> listadoProyectos = new List<Proyecto>();

        public enum Estado
        {
            nuevo, 
            preparado,
            ejecutado,
            bloqueado,
            finalizado,
        }

        private string Codigo;
        private string Descripcion;
        private DateTime Fecha_inicio;
        private DateTime Fecha_fin;
        private Estado Estado_proyecto;
        private double Presupuesto_inicial;
        private double Presupuesto_actual;
        private bool Cambios;
        private int Codigo_cliente;


        public Proyecto(string Codigo, string Descripcion, DateTime Fecha_inicio, DateTime Fecha_fin, Estado Estado_proyecto, double Presupuesto_inicial, double Presupuesto_actual, bool Cambios, int Codigo_cliente )
        {

            this.Codigo1 = Codigo;
            this.Descripcion = Descripcion;
            this.Fecha_inicio = Fecha_inicio;
            this.Estado_proyecto = Estado_proyecto;
            this.Presupuesto_inicial = Presupuesto_inicial;
            this.Presupuesto_actual = Presupuesto_actual;
            this.Cambios = Cambios;
            this.Codigo_cliente =   Codigo_cliente;

        }



        // Getters y Setters
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Codigo2 { get => Codigo; set => Codigo = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public DateTime Fecha_inicio1 { get => Fecha_inicio; set => Fecha_inicio = value; }
        public DateTime Fecha_fin1 { get => Fecha_fin; set => Fecha_fin = value; }
        internal Estado Estado_proyecto1 { get => Estado_proyecto; set => Estado_proyecto = value; }
        public double Presupuesto_inicial1 { get => Presupuesto_inicial; set => Presupuesto_inicial = value; }
        public double Presupuesto_actual1 { get => Presupuesto_actual; set => Presupuesto_actual = value; }
        public bool Cambios1 { get => Cambios; set => Cambios = value; }
        public int Codigo_cliente1 { get => Codigo_cliente; set => Codigo_cliente = value; }

        


    }


}
