using System.Data;

namespace Final_TallerProgramacion
{
    public partial class Login : Form
    {
        public Login()
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string UsuarioValido = "Admin";
            string ContraValida = "1234";

            // Comparamos los textos
            if (TextUsuario.Text.Trim() == UsuarioValido && TextContraseña.Text.Trim() == ContraValida)
            {
                // Si coinciden, abrimos el menú directamente
                Menu formMenu = new Menu();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
            }

        }

        private void TextContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

