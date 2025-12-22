using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_TallerProgramacion
{
    public partial class Estudiantes : Form
    {
        public enum ModoABM { Alta, Edicion, Visual }
        private ModoABM modoActual = ModoABM.Visual;

        public Estudiantes()
        {
            InitializeComponent();
        }

        private int idSeleccionado = 0;
        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                BtnEditarEst.Enabled = true;
                BtnEliminarEstud.Enabled = true;

                idSeleccionado = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells[0].Value);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            // 1. Carga inicial de todos los estudiantes
            CargarGrillaEstudiantes();

            // 2. Configurar ComboBox
            cmbEstudiant.Items.Clear();
            cmbEstudiant.Items.Add("Todos"); // Opción por defecto
            cmbEstudiant.Items.Add("Mayor Edad");
            cmbEstudiant.Items.Add("Menor Edad");
            cmbEstudiant.Items.Add("Edad > Al Promedio");
            cmbEstudiant.SelectedIndex = 0; // Seleccionar "Todos" por defecto

            // 3. Ocultar o limpiar el promedio
            lblResPromedio.Text = "";
        }
        public void CargarGrillaEstudiantes(string textoBusqueda = "", string filtroEdad = "")
        {
            dgvEstudiantes.DataSource = Datos.ListarEstudiantes(textoBusqueda, filtroEdad);
        }

        private void textBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            // Carga la grilla filtrando solo por el texto del nombre.
            // Al pasar "" como segundo parámetro, ignora el filtro de edad.
            CargarGrillaEstudiantes(textBuscarEstud.Text.Trim());
        }


        private void btnPromedio_Click(object sender, EventArgs e)
        {
            decimal promedio = Datos.ObtenerPromedioEdad();

            // 2. Formatear y mostrar el resultado en la etiqueta (Label)
            if (promedio > 0)
            {
                // El formato "N2" asegura que el número se muestre con dos decimales y el separador de miles local
                lblResPromedio.Text = promedio.ToString("N2");

                // Opcional: Mostrar un mensaje de éxito
                MessageBox.Show($"El promedio de edad de los estudiantes es: {promedio:N2} años.",
                                "Promedio Calculado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblResPromedio.Text = "N/A";
                MessageBox.Show("No hay datos de edad disponibles o ocurrió un error.",
                                "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbEstudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbEstudiant.SelectedItem.ToString();
            string parametroDatos = "";

            // Mapeo del texto de la UI al parámetro de la Capa de Datos
            switch (filtroSeleccionado)
            {
                case "Menor Edad":
                    parametroDatos = "Menor";
                    break;
                case "Mayor Edad":
                    parametroDatos = "Mayor";
                    break;
                case "Edad > Al Promedio":
                    parametroDatos = "Promedio";
                    break;
                case "Todos":
                default:
                    parametroDatos = ""; // Vacío significa listar todos
                    break;
            }

            // Limpiar el campo de texto de búsqueda de nombre y cargar la grilla
            textBuscarEstud.Clear();
            CargarGrillaEstudiantes("", parametroDatos);
        }

        private void BtnAgregarEst_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            textboxCodig.Focus();

            modoActual = ModoABM.Alta;

            HabilitarCampos();

            BtnEditarEst.Enabled = false;
            BtnEliminarEstud.Enabled = false;

            MessageBox.Show("Modo Alta activado. Ingrese los datos y presione ACEPTAR", "Nuevo Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
        public void LimpiarCampos()
        {
            textboxCodig.Clear();
            textboxNombre.Clear();
            textboxDireccion.Clear();
            textboxCarrera.Clear();
            textboxEdad.Clear();

            textBuscarEstud.Focus();

        }
        public void HabilitarCampos()
        {
            textboxCodig.Enabled = true;
            textboxNombre.Enabled = true;
            textboxDireccion.Enabled = true;
            textboxCarrera.Enabled = true;
            textboxEdad.Enabled = true;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxCodig.Text.Trim()) || string.IsNullOrEmpty(textboxNombre.Text.Trim()) ||
                string.IsNullOrEmpty(textboxDireccion.Text.Trim()) || string.IsNullOrEmpty(textboxCarrera.Text.Trim()) ||
                string.IsNullOrEmpty(textboxEdad.Text.Trim()))
            {
                MessageBox.Show("Debe completar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int edadConvertida = 0;

            bool esValido = int.TryParse(textboxEdad.Text.Trim(), out edadConvertida);

            if (!esValido)
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido para la Edad.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textboxEdad.Focus();
                return;
            }
            if (edadConvertida <= 0)
            {
                MessageBox.Show("La Edad debe ser mayor a 0", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textboxEdad.Focus();
                return;
            }

            Datos.EstudianteEntidad Estudiante = new Datos.EstudianteEntidad
            {
                Id = idSeleccionado,
                CI = textboxCodig.Text.Trim(),
                NombreEstudiante = textboxNombre.Text.Trim(),
                Direccion = textboxDireccion.Text.Trim(),
                Carrera = textboxCarrera.Text.Trim(),
                Edad = edadConvertida
            };

            bool resultado = false;

            if (modoActual == ModoABM.Alta)
            {
                resultado = Datos.InsertarEstudiante(Estudiante);
                if (resultado)
                {
                    MessageBox.Show("Estudiante agregado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            } else if (modoActual == ModoABM.Edicion)
            {
                resultado = Datos.ModificarEstudiante(Estudiante);
                if (resultado)
                {
                    MessageBox.Show("Estudiante Editado con Exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            if (resultado)
            {
                LimpiarCampos();
                // DeshabilitarCampos(); // Si tienes este método para bloquear los TextBox

                // REFRESCAR LA GRILLA: Llama a tu método que carga el DataGridView
                CargarGrillaEstudiantes();

                // Resetear estados
                modoActual = ModoABM.Visual;
                idSeleccionado = 0;
                BtnEditarEst.Enabled = false;
                BtnEliminarEstud.Enabled = false;
            }
        }

        private void BtnEditarEst_Click(object sender, EventArgs e)
        {
            BtnAgregarEst.Enabled = false;
            BtnEliminarEstud.Enabled = false; 


            if (idSeleccionado > 0)
            {
                textboxCodig.Text = dgvEstudiantes.CurrentRow.Cells["CI"].Value.ToString();
                textboxNombre.Text = dgvEstudiantes.CurrentRow.Cells["NombreEstudiante"].ToString();
                textboxDireccion.Text = dgvEstudiantes.CurrentRow.Cells["Direccion"].ToString();
                textboxCarrera.Text = dgvEstudiantes.CurrentRow.Cells["Carrera"].ToString();
                textboxEdad.Text = dgvEstudiantes.CurrentRow.Cells["Edad"].ToString();

                modoActual = ModoABM.Edicion;

                HabilitarCampos();
                textboxCodig.Focus();

                MessageBox.Show("Modo Edicion Activado. Modifique los campos y precione ACEPTAR.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BtnEditarEst.Enabled = true;
            BtnEliminarEstud.Enabled = true;
        }
    }
}
