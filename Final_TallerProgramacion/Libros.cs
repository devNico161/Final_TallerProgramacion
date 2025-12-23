using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final_TallerProgramacion.Datos;

namespace Final_TallerProgramacion
{
    public partial class Libros : Form
    {
        public enum ModosABM { Alta, Edicion, Visualizacion } // Definimos los posibles estados
        private ModosABM ModoActual = ModosABM.Visualizacion; // Estado inicial (solo mirando la grilla)
        public Libros()
        {
            InitializeComponent();
        }

        public void cargarLibrosInicialesParaMenuLibro()
        {
            dgvF2MenuLibros.DataSource = Datos.ListarLibros("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validaciones (Asegurarse que los campos no estén vacíos)
            if (string.IsNullOrEmpty(textboxTitulo.Text.Trim()) || string.IsNullOrEmpty(textboxEditorial.Text.Trim()) || string.IsNullOrEmpty(textboxArea.Text.Trim()))
            {
                MessageBox.Show("Debe completar Título, Editorial y Área.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Crear el objeto con los datos comunes
            Datos.LibroEntidad libro = new Datos.LibroEntidad
            {
                Titulo = textboxTitulo.Text.Trim(),
                Editorial = textboxEditorial.Text.Trim(),
                Area = textboxArea.Text.Trim()
            };

            bool resultado = false;

            // 2. Lógica de Modos: ¿Estamos editando o dando de alta?
            if (ModoActual == ModosABM.Alta)
            {
                // LLAMAR A INSERTAR
                resultado = Datos.InsertarNuevoLibro(libro);

                if (resultado) MessageBox.Show("Libro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ModoActual == ModosABM.Edicion)
            {
                // LLAMAR A MODIFICAR
                // CRÍTICO: Necesitamos el ID del TextBoxCodigo (que debería tener el ID cargado)
                if (int.TryParse(textboxIdLibro.Text, out int idLibro))
                {
                    libro.Id = idLibro;
                    resultado = Datos.ModificarLibro(libro);

                    if (resultado) MessageBox.Show("Libro modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: El Código del libro no es válido para la edición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // 3. Manejo final
            if (resultado)
            {
                // Volver al estado inicial y recargar la grilla
                LimpiarCampos();
                cargarLibrosInicialesParaMenuLibro();
                ControlDeBotones(); // Deshabilita Editar/Eliminar y limpia el modo
            }
            else if (!resultado && ModoActual != ModosABM.Visualizacion)
            {
                MessageBox.Show("Hubo un error en la operación de base de datos.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Al finalizar la operación, siempre volvemos a Visualización
            ModoActual = ModosABM.Visualizacion;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBuscarLibro_Click(object sender, EventArgs e)
        {

        }

        private void Libros_Load(object sender, EventArgs e)
        {
            cargarLibrosInicialesParaMenuLibro();
            ControlDeBotones();
        }

        private void dgvF2MenuLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Libro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnConfirmarBusqueda_Click(object sender, EventArgs e)
        {
            string termino = TextBoxBuscarLibro.Text.Trim();

            List<GrillaLibros> ListaFiltrada = Datos.ListarLibros(termino);

            if (ListaFiltrada != null && ListaFiltrada.Count > 0)
            {
                dgvF2MenuLibros.DataSource = ListaFiltrada;
                dgvF2MenuLibros.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                if (!string.IsNullOrEmpty(termino))
                {
                    MessageBox.Show($"Advertencia: No se encontraron libros que coincidan con el término: '{termino}'.",
                                    "Búsqueda sin resultados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }

                dgvF2MenuLibros.DataSource = null;


                if (string.IsNullOrEmpty(termino))
                {
                    cargarLibrosInicialesParaMenuLibro();
                }
            }

        }
        private void dgvF2MenuLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que el clic sea en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                // 1. Habilitar botones de ABM (Etapa C)
                BtnEditarLibro.Enabled = true;
                BtnEliminarLibro.Enabled = true;

                // 2. Cargar datos en los TextBoxes (Etapa D)
                DataGridViewRow filaSeleccionada = dgvF2MenuLibros.Rows[e.RowIndex];

                // Mapeo POSICIONAL de la grilla:
                // Columna 0: Id
                // Columna 1: Titulo
                // Columna 2: Editorial
                // Columna 3: Area

                textboxIdLibro.Text = filaSeleccionada.Cells[0].Value.ToString();
                textboxTitulo.Text = filaSeleccionada.Cells[1].Value.ToString();
                textboxEditorial.Text = filaSeleccionada.Cells[2].Value.ToString();
                textboxArea.Text = filaSeleccionada.Cells[3].Value.ToString();

                // Opcional: Deseleccionar los botones Nuevo/Aceptar si estaban activos
                // En este punto, estamos en modo 'Visualización/Edición Potencial'.
            }
            else
            {
                // Si se hizo clic fuera de una fila, deshabilitar (opcional)
                BtnEditarLibro.Enabled = false;
                BtnEliminarLibro.Enabled = false;
            }
        }
        public void LimpiarCampos()
        {
            textboxIdLibro.Clear(); // <-- Asegúrate de limpiar el ID
            textboxTitulo.Clear();
            textboxEditorial.Clear();
            textboxArea.Clear();

            TextBoxBuscarLibro.Focus();

        }
        public void ControlDeBotones()
        {
            BtnEditarLibro.Enabled = false;
            BtnEliminarLibro.Enabled = false;

            textboxIdLibro.Enabled = false;

            LimpiarCampos();
        }

        private void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            textboxTitulo.Focus();

            // CRÍTICO: Establecer el modo a Alta
            ModoActual = ModosABM.Alta;

            // Puedes habilitar los campos de entrada aquí si los deshabilitaste antes
            textboxTitulo.Enabled = true;
            textboxEditorial.Enabled = true;
            textboxArea.Enabled = true;

            // Opcional: Deshabilitar temporalmente Editar y Eliminar
            BtnEditarLibro.Enabled = false;
            BtnEliminarLibro.Enabled = false;

            MessageBox.Show("Modo ALTA activado. Ingrese los datos y presione ACEPTAR.", "Nuevo Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEditarLibro_Click(object sender, EventArgs e)
        {
            // Como los TextBoxes ya se llenaron en CellClick, solo cambiamos el modo

            // CRÍTICO: Establecer el modo a Edición
            ModoActual = ModosABM.Edicion;

            // Habilitar la edición de los campos (si estaban deshabilitados)
            textboxTitulo.Enabled = true;
            textboxEditorial.Enabled = true;
            textboxArea.Enabled = true;

            MessageBox.Show("Modo EDICIÓN activado. Modifique los datos y presione ACEPTAR.", "Editar Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEliminarLibro_Click(object sender, EventArgs e)
        {
            // 1. Verificación de ID
            if (!int.TryParse(textboxIdLibro.Text, out int idLibroAEliminar))
            {
                MessageBox.Show("Debe seleccionar un libro válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Pedir Confirmación al Usuario
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar el libro con Código {idLibroAEliminar}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                // 3. Llamada a la capa de datos
                bool resultado = Datos.EliminarLibro(idLibroAEliminar);

                // 4. Manejo del Resultado
                if (resultado)
                {
                    MessageBox.Show("Libro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Este mensaje puede aparecer si hubo un error en la base de datos o por Claves Foráneas
                    MessageBox.Show("Hubo un error al intentar eliminar el libro. (Puede haber préstamos asociados)", "Fallo de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // 5. Actualizar la Interfaz
                LimpiarCampos();
                cargarLibrosInicialesParaMenuLibro(); // Recarga la grilla
                ControlDeBotones();          // Vuelve a deshabilitar Editar/Eliminar
            }
            // Si la confirmación no es 'Yes', no hacemos nada.
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
    }
}

