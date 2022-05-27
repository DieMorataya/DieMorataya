namespace TAREA3PILASYCOLAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            //Aqui se enlaza el form principal con el form pilas
            this.Hide();
            Pilas NuevaVentana1 = new Pilas();
            NuevaVentana1.Show();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            //Aqui se enlaza el form principal con el form colas
            this.Hide();
            Colas NuevaVentana2 = new Colas();  
            NuevaVentana2.Show();   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}