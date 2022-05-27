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
    public partial class Colas : Form
    {
        Queue<DATOS.DATOS> usuariocola = new Queue<DATOS.DATOS>();
        public Colas()
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

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            DATOS.DATOS datosColas = new DATOS.DATOS();
            datosColas.ID = int.Parse(txtID.Text);
            datosColas.Nombre = txtNombre.Text;
            datosColas.Edad = int.Parse(txtEdad.Text);
            usuariocola.Enqueue(datosColas); //Aqui se agregan datos a la cola
            datagridColas.DataSource = null;
            datagridColas.DataSource = usuariocola.ToArray();

            //LIMPIAR CONTROLADORES
            txtID.Clear();
            txtNombre.Clear();
            txtEdad.Clear();

            MessageBox.Show("Datos ingresados correctamente en la cola");
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            if (usuariocola.Count != 0)
            {
                if (MessageBox.Show("Desea eliminar el registro de la cola? ", "ATENCION", //PREGUNTA SI QUIERE ELIMINAR EL REGISTRO DE LA COLA
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    DATOS.DATOS datosColas = new DATOS.DATOS();
                    datosColas = usuariocola.Dequeue(); //AQUI SE ELIMINA EL DATO DE LA COLA 
                    txtID.Text = datosColas.ID.ToString();
                    txtNombre.Text = datosColas.Nombre;
                    txtEdad.Text = datosColas.Edad.ToString();
                    datagridColas.DataSource = usuariocola.ToArray();


                    MessageBox.Show("Se elimino el registro que estaba en la cola");
                }



            }
            else
            {
                MessageBox.Show("No hay registros en la cola"); //MENSAJE QUE SE MUESTRA CUANDO NO HAY NINGUN DATO EN LA COLA
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
