using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAREA3PILASYCOLAS.DATOS;

namespace TAREA3PILASYCOLAS
{
    public partial class Pilas : Form
    {
        Stack<DATOS.DATOS> usuario = new Stack<DATOS.DATOS>();
        public Pilas()
        {
            InitializeComponent();
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            //Aqui regresa al form principal
            this.Hide();
            Form1 VentanaPrincipal = new Form1();
            VentanaPrincipal.Show();
        }

        private void btnAgregar1_Click(object sender, EventArgs e) //AQUI SE AGREGAN LOS DATOS A LA PILA
        {
            DATOS.DATOS datosU = new DATOS.DATOS();
            datosU.ID = int.Parse(txtID.Text);
            datosU.Nombre = txtNombre.Text;
            datosU.Edad = int.Parse(txtEdad.Text);
            usuario.Push(datosU); //Aqui se agregan datos a la pila
            datagridPilas.DataSource = null;
            datagridPilas.DataSource = usuario.ToArray();

            //LIMPIAR CONTROLADORES
            txtID.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
          
            MessageBox.Show("Datos ingresados correctamente en la pila");
        }

        private void btnEliminar1_Click(object sender, EventArgs e) //AQUI SE ELIMINAN LOS DATOS DE LA PILA (POP)
        {
            if(usuario.Count != 0)
            {
                if(MessageBox.Show("Desea eliminar el registro de la pila? ", "ATENCION", //PREGUNTA SI QUIERE ELIMINAR EL REGISTRO DE LA PILA
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==DialogResult.Yes)
                {


                    DATOS.DATOS datosU = new DATOS.DATOS();
                   datosU = usuario.Pop();
                   txtID.Text = datosU.ID.ToString();
                   txtNombre.Text = datosU.Nombre;
                   txtEdad.Text = datosU.Edad.ToString();
                   datagridPilas.DataSource = usuario.ToArray();


                    MessageBox.Show("Se elimino el registro que estaba en la pila");
                }

                

            }
            else
            {
                MessageBox.Show("No hay registros en la pila"); //MENSAJE QUE SE MUESTRA CUANDO NO HAY NINGUN DATO EN LA PILA
            }

            //LIMPIAR CONTROLADORES
               txtID.Clear();
               txtNombre.Clear();
               txtEdad.Clear();


        }

        //VALIDACIONES
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
            }
            else
            {
                e.Handled = false;
                
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
            }
            else
            {
                e.Handled = false;

            }
        }
    }
}
