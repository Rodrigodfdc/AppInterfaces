using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        int contador = 0; // Dejo el contador 
        private void button1_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
            Boolean validacion = validarLogin(textBox1.Text, textBox2.Text);
            if (validacion)
            {

                textBox1.Clear();
                textBox2.Clear();
                /* Para cerrar la pantalla en la que estoy
                 * No me deja usar el método this.Close(), pero si el Hide no entiendo el porqué.
                 *
                 */

                this.Hide();
                PrincipalOpciones menu = new PrincipalOpciones();
                menu.ShowDialog();


               
                return;

            }
            else
            {
                contador++;
                if (contador < 3)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                    MessageBox.Show("Usuario o clave incorrecta");
                }
                else
                {
                    MessageBox.Show("Ha superado el limite de intentos");
                    Application.Exit();
                }
            }

        }
        private void boxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has pulsado Cancelar");
        }

        private void FrmProyectos_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Para declarar la lista:
        private List<Usuario> listaUsuarios = new List<Usuario>();
        //Para rellenar la lista:
        private void cargarUsuarios()
        {
            listaUsuarios.Add(new Usuario("root", "1234"));
            listaUsuarios.Add(new Usuario("juan", "4321"));
            listaUsuarios.Add(new Usuario("jaime", "4444"));
            listaUsuarios.Add(new Usuario("jose", "1111"));
            listaUsuarios.Add(new Usuario("javier", "2222"));
            listaUsuarios.Add(new Usuario("jorge", "3333"));
        }

        private bool validarLogin(string Id, string Clave)
        {

            int posicion = listaUsuarios.FindIndex(x => x.id == Id.ToLower());

            if (posicion != -1 && listaUsuarios[posicion].clave == Clave)

            {

                return true;
            }
             return false;

        }

    }

    }

