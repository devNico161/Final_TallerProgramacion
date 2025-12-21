using System.Data;

namespace Final_TallerProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            // 1. Cambiamos el color a uno de "activo" (ej. Rojo o Azul Oscuro)
            label1.ForeColor = System.Drawing.Color.Red;

            // 2. Subrayamos el texto para que parezca un enlace
            label1.Font = new System.Drawing.Font(
                label1.Font,
                System.Drawing.FontStyle.Underline
            );
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            // 1. Lo devolvemos al color original (Azul)
            label1.ForeColor = System.Drawing.Color.Blue;

            // 2. Quitamos el subrayado, volviendo al estilo regular
            label1.Font = new System.Drawing.Font(
                label1.Font,
                System.Drawing.FontStyle.Regular
            );
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            // *** 1. Lógica de Conexión y Apertura de Menú ***
            Conexion objConexion = new Conexion();

            // Verificamos la conexión antes de continuar
            if (objConexion.AbrirConexion().State == ConnectionState.Open)
            {
                MessageBox.Show("¡Conexión Exitosa a la base de datos Final!");
                objConexion.CerrarConexion(); // Cerramos la conexión después de la prueba

                // Creamos la instancia del menú
                Menu formMenu = new Menu();

                // NO LLAMAMOS A LA CARGA AQUÍ. La carga se hará en el evento Shown del Menu.

                formMenu.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Error de conexión al servidor. No se puede iniciar el programa.");
            }
        }
    }
}

