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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            // *** CONFIGURACIÓN FORZADA DE VISIBILIDAD EN EL CONSTRUCTOR ***
            // Esto anula cualquier propiedad residual corrupta en el diseñador.
            if (dgv_Libros != null)
            {
                dgv_Libros.Visible = true;
                dgv_Libros.ColumnHeadersVisible = true;
                dgv_Libros.RowHeadersVisible = true;
                dgv_Libros.AutoGenerateColumns = true;
            }
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            CargarLibrosIniciales();
        }

        public void CargarLibrosIniciales()
        {
            // 1. Asignar Data Source 
            dgv_Libros.DataSource = Datos.ListarLibros("");

        }

        // MÉTODOS DE MENÚ Y LOAD DEBEN QUEDAR LIMPIOS:

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementación vacía
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CargarLibrosIniciales();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Implementación vacía
        }

        private void dgv_Libros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //CargarLibrosIniciales();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libros formLibros = new Libros();
            formLibros.Show();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autores formAutores = new Autores();

            formAutores.Show();

        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiantes formEstud = new Estudiantes();

            formEstud.Show();
        }
    }
}