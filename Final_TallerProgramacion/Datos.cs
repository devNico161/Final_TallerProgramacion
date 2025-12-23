using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace Final_TallerProgramacion
{
    internal class Datos
    {
        internal class GrillaLibros
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Editorial { get; set; }
            public string Area { get; set; }
            public bool Estado { get; set; }

        }

        internal class GrillaAutores
        {
            public string NombreAutor {  get; set; }
            public string NombreLibro { get; set; }
            public string Nacionalidad {  get; set; }
        }

        internal class GrillaEstudiantes
        {
            public int IdEstudiante { get; set; }
            public string CI { get; set; }
            public string NombreEstudiante {  get; set; }
            public string Direccion {  get; set; }
            public string Carrera {  get; set; }
            public int Edad {  get; set; }
        }

        public class LibroEntidad
        {
            // Usado para MODIFICAR y ELIMINAR
            public int Id { get; set; }

            // Usado para INSERTAR y MODIFICAR
            public string Titulo { get; set; }
            public string Editorial { get; set; }
            public string Area { get; set; }
        }

        public class EstudianteEntidad
        {
            public int Id { get; set; }
            public string CI { get; set; }
            public string NombreEstudiante { get; set; }
            public string Direccion { get; set; }
            public string Carrera { get; set; }
            public int Edad { get; set; }
        }
        
        public static List<GrillaLibros> ListarLibros(string textoBusqueda)
        {
            List<GrillaLibros> ListaLibros = new List<GrillaLibros>();
            Conexion ObjConexion = new Conexion();

            string consultaSQL;
            
            // Nombres de columna de la vista ListaDeLibrosMenu:
            string columnas = "Id, Titulo, Editorial, Area, Estado"; 

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                // CARGA INICIAL (Trae todos los libros)
                consultaSQL = $"SELECT {columnas} FROM ListaDeLibrosMenu"; 
            }
            else
            {
                // BÚSQUEDA (Filtra por LIKE)
                consultaSQL = $"SELECT {columnas} FROM ListaDeLibrosMenu WHERE " +
                              "Titulo LIKE @Filtro OR " +
                              "Editorial LIKE @Filtro OR " +
                              "Area LIKE @Filtro";
            }

            using (SqlConnection conexion = ObjConexion.AbrirConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(consultaSQL, conexion))
                    {
                        if (!string.IsNullOrEmpty(textoBusqueda))
                        {
                            // Agregamos el parámetro solo si estamos buscando
                            comando.Parameters.AddWithValue("@Filtro", "%" + textoBusqueda + "%");
                        }
                        
                        SqlDataReader reader = comando.ExecuteReader();
                        while (reader.Read())
                        {
                            // Mapeo POSICIONAL de las 5 columnas
                            GrillaLibros Libro = new GrillaLibros()
                            {
                                Id = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                Editorial = reader.GetString(2),
                                Area = reader.GetString(3),
                                Estado = reader.GetInt32(4) == 1 
                            };
                            ListaLibros.Add(Libro);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Muestra el error de SQL si la conexión o la consulta fallan
                    MessageBox.Show("Error de Base de Datos al listar/buscar libros: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ObjConexion.CerrarConexion();
                }
            }
            return ListaLibros;
        }

        public static bool ModificarLibro(LibroEntidad libroEditado)
        {
            Conexion ObjConexion = new Conexion();
            string spNombre = "SP_Libro_Modificar";

            using (SqlConnection conexion = ObjConexion.AbrirConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(spNombre, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // CRÍTICO: El SP de modificación requiere el ID
                        comando.Parameters.AddWithValue("@IdLibro", libroEditado.Id);
                        comando.Parameters.AddWithValue("@Titulo", libroEditado.Titulo);
                        comando.Parameters.AddWithValue("@Editorial", libroEditado.Editorial);
                        comando.Parameters.AddWithValue("@Area", libroEditado.Area);

                        // ExecuteScalar se usa porque el SP devuelve @@ROWCOUNT
                        object resultado = comando.ExecuteScalar();

                        // Verificamos si se afectó al menos una fila (es decir, el update funcionó)
                        if (resultado != null && resultado != DBNull.Value && Convert.ToInt32(resultado) > 0)
                        {
                            return true;
                        }

                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar modificar el libro: " + ex.Message, "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    ObjConexion.CerrarConexion();
                }
            }
        }
        public static bool InsertarNuevoLibro(LibroEntidad nuevoLibro)
        {
            Conexion ObjConexion = new Conexion();
            string spNombre = "SP_Libro_Insertar";

            using (SqlConnection conexion = ObjConexion.AbrirConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(spNombre, conexion))
                    {
                        // CRÍTICO: Especificar que estamos ejecutando un Stored Procedure
                        comando.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros (el ID no se pasa, es autoincremental)
                        comando.Parameters.AddWithValue("@Titulo", nuevoLibro.Titulo);
                        comando.Parameters.AddWithValue("@Editorial", nuevoLibro.Editorial);
                        comando.Parameters.AddWithValue("@Area", nuevoLibro.Area);

                        // Ejecutamos el comando y capturamos el resultado del SCOPE_IDENTITY()
                        object resultado = comando.ExecuteScalar();

                        // Si resultado es un número válido, la inserción fue exitosa
                        return resultado != null && resultado != DBNull.Value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar insertar el libro: " + ex.Message, "Error de Inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    ObjConexion.CerrarConexion();
                }
            }
        }
        public static bool EliminarLibro(int idLibroAEliminar)
        {
            Conexion ObjConexion = new Conexion();
            string spNombre = "SP_Libro_Eliminar";

            using (SqlConnection conexion = ObjConexion.AbrirConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(spNombre, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // CRÍTICO: Pasamos el ID del libro que queremos eliminar
                        comando.Parameters.AddWithValue("@IdLibro", idLibroAEliminar);

                        // ExecuteScalar se usa porque el SP devuelve @@ROWCOUNT
                        object resultado = comando.ExecuteScalar();

                        // Verificamos si se afectó al menos una fila (es decir, la eliminación funcionó)
                        if (resultado != null && resultado != DBNull.Value && Convert.ToInt32(resultado) > 0)
                        {
                            return true;
                        }

                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de Base de Datos al intentar eliminar el libro: " + ex.Message, "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    ObjConexion.CerrarConexion();
                }
            }
        }

        public static bool InsertarEstudiante (EstudianteEntidad NuevoEstudiante)
        {
            Conexion Objconexion = new Conexion();
            string sp_Nombre = "SP_Estudiante_Insertar";

            using (SqlConnection conexion = Objconexion.AbrirConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(sp_Nombre, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@CI", NuevoEstudiante.CI);
                        comando.Parameters.AddWithValue("@Nombre", NuevoEstudiante.NombreEstudiante);
                        comando.Parameters.AddWithValue("@Direccion", NuevoEstudiante.Direccion);
                        comando.Parameters.AddWithValue("@Carrera", NuevoEstudiante.Carrera);
                        comando.Parameters.AddWithValue("@Edad", NuevoEstudiante.Edad);

                        object resultado = comando.ExecuteScalar();

                        return resultado != null && resultado != DBNull.Value;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el Estudiante:" + ex.Message, "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    Objconexion.CerrarConexion();
                }
            }
        }
        public static bool ModificarEstudiante(EstudianteEntidad EstudianteEditado)
        {
            Conexion Objconexion = new Conexion();
            try
            {
                using (SqlConnection conexion = Objconexion.AbrirConexion())
                {
                    using (SqlCommand comando = new SqlCommand("SP_EditarEstudiante", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Id", EstudianteEditado.Id);
                        comando.Parameters.AddWithValue("@CI", EstudianteEditado.CI);
                        comando.Parameters.AddWithValue("@Nombre", EstudianteEditado.NombreEstudiante);
                        comando.Parameters.AddWithValue("@Direccion", EstudianteEditado.Direccion);
                        comando.Parameters.AddWithValue("@Carrera", EstudianteEditado.Carrera);
                        comando.Parameters.AddWithValue("@Edad", EstudianteEditado.Edad);

                        int filas = comando.ExecuteNonQuery();
                        return filas > 0;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al modificar", ex.Message);
                return false;
            }
            finally
            {
                Objconexion.CerrarConexion();
            }
        }
        public static bool EliminarEstudiante (int idEstudianteAEliminar)
        {
            Conexion Objconexion = new Conexion();
            try
            {
                using (SqlConnection conexion = Objconexion.AbrirConexion())
                {
                    using (SqlCommand comando = new SqlCommand("SP_Estudiante_Eliminar", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Id", idEstudianteAEliminar);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Objconexion.CerrarConexion();
            }
        }
        public static List<GrillaAutores> listarAutores(string textoBusqueda = "", string campoBusqueda = "")
        {
            List<GrillaAutores> listaAutores = new List<GrillaAutores>();

            Conexion ObjConexion = new Conexion();

            string consultaSQL = "SELECT NombreAutor, NombreLibro, Nacionalidad  FROM VW_AutoresParaGrilla";

            if (!string.IsNullOrEmpty(textoBusqueda) && !string.IsNullOrEmpty(campoBusqueda))
            {
                // Construye la cláusula WHERE usando el campo dinámico y el parámetro seguro @Filtro
                // Esto asume que campoBusqueda solo puede ser: NombreAutor, Nacionalidad o NombreLibro
                consultaSQL += $" WHERE {campoBusqueda} LIKE @Filtro";
            }

            using (SqlConnection conexion = ObjConexion.AbrirConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(consultaSQL, conexion))
                    {
                        if (!string.IsNullOrEmpty(textoBusqueda))
                        {
                            // Agregamos el parámetro seguro para evitar inyección SQL
                            comando.Parameters.AddWithValue("@Filtro", "%" + textoBusqueda + "%");
                        }

                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            listaAutores.Add(new GrillaAutores()
                            {
                                NombreAutor = reader.GetString(0),
                                NombreLibro = reader.GetString(1),
                                Nacionalidad = reader.GetString(2)
                            });
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de Base de Datos al listar autores: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ObjConexion.CerrarConexion();
                }
            }
            return listaAutores;
        }

        public static List<GrillaEstudiantes> ListarEstudiantes(string textoBusqueda = "", string filtroEdad = "")
        {
            List<GrillaEstudiantes> listaEstudiate = new List<GrillaEstudiantes>();
            Conexion Objconexion = new Conexion();

            string consultaSql = " SELECT IdEstudiantes, CI, Nombre, Direccion, Carrera, Edad  FROM Estudiantes";

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                consultaSql += " WHERE Nombre LIKE @Filtro";
            }
            else if (!string.IsNullOrEmpty(filtroEdad))
            {
                if(filtroEdad == "Mayor")
                {
                    consultaSql += " WHERE Edad = (SELECT MAX(Edad) FROM Estudiantes)";
                }
                else if (filtroEdad == "Menor")
                {
                    consultaSql += " WHERE Edad = (SELECT MIN(Edad) FROM Estudiantes)";
                }
                else if (filtroEdad == "Promedio") // Nuevo caso para 'Edad > Al Promedio'
                {
                    // Opcional: Podrías calcular el promedio aquí mismo o llamar al otro método.
                    // Para simplificar, obtenemos el promedio y lo usamos en la consulta.
                    decimal promedio = ObtenerPromedioEdad();
                    // Usamos un parámetro @Promedio para la consulta
                    consultaSql += " WHERE Edad > @Promedio";
                }
            }
            using (SqlConnection conexion = Objconexion.AbrirConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                    {
                        if (!string.IsNullOrEmpty(textoBusqueda))
                        {
                            // Usa el mismo parámetro para buscar nombres que empiecen o contengan
                            comando.Parameters.AddWithValue("@Filtro", "%" + textoBusqueda + "%");
                        }
                        else if (filtroEdad == "Promedio") // Nuevo caso para 'Edad > Al Promedio'
                        {
                            // Opcional: Podrías calcular el promedio aquí mismo o llamar al otro método.
                            // Para simplificar, obtenemos el promedio y lo usamos en la consulta.
                            decimal promedio = ObtenerPromedioEdad();
                            // Usamos un parámetro @Promedio para la consulta
                            consultaSql += " WHERE Edad > @Promedio";
                        }

                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            listaEstudiate.Add(new GrillaEstudiantes()
                            {
                                IdEstudiante = reader.GetInt32(0),
                                CI = reader.GetString(1),
                                NombreEstudiante = reader.GetString(2),
                                Direccion = reader.GetString(3),
                                Carrera = reader.GetString(4),
                                Edad = reader.GetInt32(5)
                            });               
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de Base de Datos al listar estudiantes: " 
                                       + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Objconexion.CerrarConexion();
                }
            }
            return listaEstudiate;
        }

        public static decimal ObtenerPromedioEdad()
        {
            Conexion Objconexion = new Conexion();
            decimal promedioResultado = 0m;

            string consultaSql = "SELECT AVG(CAST(Edad AS Decimal (10,2))) FROM Estudiantes";

            using (SqlConnection conexion = Objconexion.AbrirConexion())
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                    {
                        Object resultado = comando.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            promedioResultado = Convert.ToDecimal(resultado);
                        }
                       
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al calcular el promedio de edad: " + ex.Message, 
                                    "Error de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    promedioResultado = 0m;
                }
                finally
                {
                    Objconexion.CerrarConexion();
                }

            }
            return promedioResultado;
        }

        public DataTable ObtenerEstudiante ()
        {
            Conexion Objconexion = new Conexion();
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = Objconexion.AbrirConexion())
                {
                    string Consulta = "SELECT IdEstudiantes, Nombre FROM Estudiantes";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(Consulta, conexion))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Estudiante", ex.Message);
            }
            return dt;
        }
        public DataTable ObtenerLibros()
        {
            Conexion Objconexion = new Conexion();
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = Objconexion.AbrirConexion())
                {
                    string Consulta = "SELECT IdLibro, Titulo FROM Libro";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(Consulta, conexion))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error libros: " + ex.Message);
            }
            return dt;
        }
    }
}
