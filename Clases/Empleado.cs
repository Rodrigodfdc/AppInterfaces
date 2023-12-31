﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Empleado
    {

        //List

        public static List<Empleado> listadoEmpleado = new List<Empleado>();


        //Atributo

        private string id;
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string puesto;
        private string telefono;
        private string correo;
        private DateTime fecha_nacimiento;
        private string ss;
        private string comentario;



        // Constructor
        public Empleado(string id, string dni, string nombre, string apellido1, string apellido2, string puesto, string telefono, string correo, DateTime fecha_nacimiento, string ss, string comentario)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.puesto = puesto;
            this.telefono = telefono;
            this.correo = correo;
            this.fecha_nacimiento = fecha_nacimiento;
            this.ss = ss;
            this.comentario = comentario;
        }


        // Getters y Setters
        public string Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Ss { get => ss; set => ss = value; }
        public string Comentario { get => comentario; set => comentario = value; }






        // Métodos propios.

        public bool EsJefe()
        {

            if (this.puesto.Equals("jefe"))
            {
                return true;
            }
                else

            { 
               return false;
            }

        }

        public void CambiarComentarios(string nuevocomentario)
        {

            this.Comentario = nuevocomentario;


        }

    }

}
