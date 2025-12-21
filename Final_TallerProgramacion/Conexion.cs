using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;



namespace Final_TallerProgramacion
{
    public class Conexion
    {
        // 1. Cadena de Conexión (El "cable" que conecta)
        // ¡IMPORTANTE! Debes cambiar 'NOMBRE_SERVIDOR' por el nombre de tu servidor.
        // Ejemplo si usas la instancia local SQLEXPRESS: "Data Source=.\\SQLEXPRESS; Initial Catalog=BIBLIOTECA; Integrated Security=True;"
        private string cadenaConexion = "Data Source=localhost; Initial Catalog=Final; Integrated Security=True; TrustServerCertificate=True";

        // 2. Objeto de Conexión
        private SqlConnection conectar = new SqlConnection();

        // Método Constructor: Se ejecuta automáticamente al crear un objeto 'Conexion'.
        public Conexion()
        {
            // Asignamos la cadena definida arriba al objeto de conexión
            Conectar.ConnectionString = cadenaConexion;
        }

        public SqlConnection Conectar { get => conectar; set => conectar = value; }

        // 3. Método para Abrir la Conexión
        public SqlConnection AbrirConexion()
        {
            try
            {
                // Solo abrimos si la conexión está cerrada
                if (Conectar.State == ConnectionState.Closed)
                {
                    Conectar.Open();
                }
            }
            catch (Exception ex)
            {
                // Si hay un error, lo mostramos. Esto te ayuda a depurar.
                Console.WriteLine("Error al intentar abrir la conexión: " + ex.Message);
            }
            return Conectar; // Devolvemos el objeto de conexión
        }

        // 4. Método para Cerrar la Conexión
        public void CerrarConexion()
        {
            // Solo cerramos si la conexión está abierta
            if (Conectar.State == ConnectionState.Open)
            {
                Conectar.Close();
            }
        }
    }
}
