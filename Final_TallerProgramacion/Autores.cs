using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_TallerProgramacion
{
    public partial class Autores : Form
    {
        public Autores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            // Buscamos si el Menú ya está abierto pero oculto
            Form menu = Application.OpenForms["Menu"];

            if (menu != null)
            {
                menu.Show(); // Muestra el menú que ya existía
            }
            else
            {
                Menu nuevoMenu = new Menu();
                nuevoMenu.Show();
            }

            this.Close(); // Cierra DEFINITIVAMENTE el formulario actual (libera memoria)
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBuscarAutor.Enabled = cmbAutores.SelectedIndex > -1;
            textBuscarAutor.Clear();
            textBuscarAutor.Focus();
        }

        private void Autores_Load(object sender, EventArgs e)
        {
            CargarGrillaAutores();
            ConfigurarBusquedaInicial();
        }
        public void CargarGrillaAutores(string textoBusqueda = "", string campoBusqueda = "")
        {

            dgv_Autores.DataSource = Datos.listarAutores(textoBusqueda, campoBusqueda);
        }
        private void ConfigurarBusquedaInicial()
        {
            // 1. Bloquear la barra de búsqueda (textBuscarAutor)
            textBuscarAutor.Enabled = false;

            // 2. Llenar el ComboBox
            cmbAutores.Items.Clear(); // Limpiar por si acaso
            cmbAutores.Items.Add("NombreAutor");
            cmbAutores.Items.Add("Nacionalidad");
            cmbAutores.Items.Add("NombreLibro");
            cmbAutores.SelectedIndex = -1; // Dejar sin selección inicial
        }

        private void BtnConfirmarBusqueda_Click(object sender, EventArgs e)
        {
            // 1. Obtener los parámetros de búsqueda del formulario
            string textoFiltro = textBuscarAutor.Text.Trim(); // .Trim() elimina espacios al inicio/final

            // 2. Obtener el campo de búsqueda seleccionado.
            // Usamos el operador de interrogación (?) para asegurar que SelectedItem no sea null.
            string campoFiltro = cmbAutores.SelectedItem?.ToString();


            // VALIDACIÓN IMPORTANTE
            // Solo permitimos buscar si el ComboBox tiene una opción seleccionada
            if (string.IsNullOrEmpty(campoFiltro) && !string.IsNullOrEmpty(textoFiltro))
            {
                MessageBox.Show("Por favor, selecciona un campo de búsqueda (NombreAutor, Nacionalidad o NombreLibro).", "Filtro Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si el texto de búsqueda está vacío, simplemente listamos todo.
            if (string.IsNullOrEmpty(textoFiltro) && string.IsNullOrEmpty(campoFiltro))
            {
                // El usuario borró el texto y presionó Buscar, o nunca seleccionó nada.
                CargarGrillaAutores();
                return;
            }


            // 3. Llamar a la función que cargará la grilla con los filtros
            CargarGrillaAutores(textoFiltro, campoFiltro);
        }
    }
}
