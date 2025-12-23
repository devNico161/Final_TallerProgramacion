using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_TallerProgramacion
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();

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
        public void CargarDatosIniciales()
        {
            Datos objDatos = new Datos();

            // 1. Cargar Libros en el CheckedListBox
            DataTable dtLibro = objDatos.ObtenerLibros();
            checkLisLibros.DataSource = dtLibro;
            checkLisLibros.DisplayMember = "Titulo";
            checkLisLibros.ValueMember = "IdLibro";

            // 2. Cargar Estudiantes al final
            DataTable dtEst = objDatos.ObtenerEstudiante();
            cmbSeleccionEstudiante.DataSource = dtEst;
            cmbSeleccionEstudiante.DisplayMember = "Nombre";
            cmbSeleccionEstudiante.ValueMember = "IdEstudiantes";

            // 3. Limpiar selección inicial para que no cargue nada al empezar
            cmbSeleccionEstudiante.SelectedIndex = -1;
            dgvPendientes.DataSource = null;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (checkLisLibros.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona al menos un libro.");
                return;
            }

            int idLector = Convert.ToInt32(cmbSeleccionEstudiante.SelectedValue);
            DateTime fechaIni = dtmFechaInicio.Value;
            DateTime fechaDev = dtmFechaDevolucion.Value;

            Conexion objCon = new Conexion();
            try
            {
                using (SqlConnection conexion = objCon.AbrirConexion())
                {
                    // Recorremos cada libro tildado
                    foreach (DataRowView libro in checkLisLibros.CheckedItems)
                    {
                        int idLibro = Convert.ToInt32(libro["IdLibro"]);

                        // 1. Insertar el Préstamo
                        string queryPrestamo = "INSERT INTO Prestamo (IdLector, IdLibro, FechaPrestamo, FechaDevolucion, Devuelto) VALUES (@idL, @idLib, @fP, @fD, 0)";

                        // 2. ACTUALIZAR EL ESTADO DEL LIBRO (Suponiendo que tienes una columna 'Estado' tipo BIT en la tabla Libro)
                        string queryActualizarLibro = "UPDATE Libro SET Estado = 1 WHERE IdLibro = @idLib";

                        using (SqlCommand cmd = new SqlCommand(queryPrestamo, conexion))
                        {
                            cmd.Parameters.AddWithValue("@idL", idLector);
                            cmd.Parameters.AddWithValue("@idLib", idLibro);
                            cmd.Parameters.AddWithValue("@fP", fechaIni);
                            cmd.Parameters.AddWithValue("@fD", fechaDev);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmdUpdate = new SqlCommand(queryActualizarLibro, conexion))
                        {
                            cmdUpdate.Parameters.AddWithValue("@idLib", idLibro);
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("¡Préstamo registrado con éxito!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al registrar: " + ex.Message); }
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvPendientes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un libro de la lista de pendientes.");
                return;
            }

            // Obtenemos los datos de la fila seleccionada en la grilla de pendientes
            int idLibroADevolver = Convert.ToInt32(dgvPendientes.CurrentRow.Cells["IdLibro"].Value);
            int idLector = Convert.ToInt32(cmbSeleccionEstudiante.SelectedValue);
            // Usamos la fecha original para identificar el prestamo exacto
            DateTime fechaP = Convert.ToDateTime(dgvPendientes.CurrentRow.Cells["FechaPrestamo"].Value);

            Conexion objCon = new Conexion();
            try
            {
                using (SqlConnection con = objCon.AbrirConexion())
                {
                    // 1. Marcamos como devuelto (1) en la tabla Prestamo
                    string queryP = @"UPDATE Prestamo SET Devuelto = 1, FechaDevolucion = GETDATE() 
                             WHERE IdLector = @idL AND IdLibro = @idLib AND FechaPrestamo = @fP";

                    // 2. IMPORTANTE: Ponemos el Estado en 0 (Disponible) en la tabla Libro
                    // Esto es lo que hará que se destilde en tu grilla de las fotos 2 y 3
                    string queryL = "UPDATE Libro SET Estado = 0 WHERE IdLibro = @idLib";

                    using (SqlCommand cmd1 = new SqlCommand(queryP, con))
                    {
                        cmd1.Parameters.AddWithValue("@idL", idLector);
                        cmd1.Parameters.AddWithValue("@idLib", idLibroADevolver);
                        cmd1.Parameters.AddWithValue("@fP", fechaP);
                        cmd1.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd2 = new SqlCommand(queryL, con))
                    {
                        cmd2.Parameters.AddWithValue("@idLib", idLibroADevolver);
                        cmd2.ExecuteNonQuery();
                    }

                    MessageBox.Show("Libro devuelto con éxito. Ahora aparecerá disponible en el Menú de Libros.");

                    // Refrescar las listas
                    CargarLibrosPendientes();
                    CargarDatosIniciales();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al devolver: " + ex.Message); }
        }

        private void CargarLibrosPendientes()
        {
            // Validamos que haya un estudiante seleccionado para evitar errores al cargar
            if (cmbSeleccionEstudiante.SelectedValue == null || cmbSeleccionEstudiante.ValueMember == "")
                return;

            int idEstudiante;
            // Intenta convertir el valor seleccionado a entero
            if (!int.TryParse(cmbSeleccionEstudiante.SelectedValue.ToString(), out idEstudiante))
                return;

            Conexion objCon = new Conexion();
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = objCon.AbrirConexion())
                {
                    // Consulta SQL que cruza Prestamo con Libro para traer el Título
                    string query = @"SELECT P.IdLibro, L.Titulo, P.FechaPrestamo 
                            FROM Prestamo P 
                            INNER JOIN Libro L ON P.IdLibro = L.IdLibro 
                            WHERE P.IdLector = @idEst AND P.Devuelto = 0";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@idEst", idEstudiante);
                        adapter.Fill(dt);
                    }
                }

                // Asignamos el resultado a la grilla
                dgvPendientes.DataSource = dt;

                // Opcional: Ocultar el IdLibro para que el usuario solo vea el Título
                if (dgvPendientes.Columns.Contains("IdLibro"))
                    dgvPendientes.Columns["IdLibro"].Visible = false;
            }
            catch (Exception ex)
            {
                // No mostramos error aquí para evitar pop-ups molestos al iniciar el form
                Console.WriteLine("Error al cargar pendientes: " + ex.Message);
            }
        }

        private void cmbSeleccionEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLibrosPendientes();
        }
    }
}
