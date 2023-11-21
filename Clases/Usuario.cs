using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Usuario
    {
        // Dejo los atributos en private para poder acceder a él después con otros métdos public
        private string Id;

        private string Clave;

        // Creo el constructor con sus atributos
        public Usuario(string Id, string Clave)
        {
            this.Id = Id;
            this.Clave = Clave;
        }

        //Creo el método public id para poder acceder a la a la variable privada Id
        public string id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        //Creo el método public clave para poder acceder a la a la variable privada Clave
        public string clave
        {
            get { return this.Clave; }
            set { this.Clave = value; }
        }
    
    }

}
