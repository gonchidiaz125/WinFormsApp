using Datos.Entities;
using System.Data.SqlClient;

namespace Datos
{
    public class LocalidadRepository
    {
        string connectionString = "Server=localhost;Database=TestGonchi;Trusted_Connection=True;MultipleActiveResultSets=true";

        public Localidad Get(int id)
        {
            Localidad localidad = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo, IdDepartamento FROM Localidades WHERE Id=@Id", connection))
                {
                    command.Parameters.AddWithValue("id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            localidad = new Localidad
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                IdDepartamento = Convert.ToInt32(reader["IdDepartamento"]),
                            };
                        }
                    }
                }
            }
            return localidad;
        }
        public IEnumerable<Localidad> Get()
        {
            List<Localidad> localidades = new List<Localidad>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo, IdDepartamento FROM Localidades", connection))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var localidad = new Localidad
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                IdDepartamento = Convert.ToInt32(reader["IdDepartamento"])
                            };
                            localidades.Add(localidad);
                        }
                    }
                }
            }
            return localidades;
        }
        public IEnumerable<Localidad> GetActivas()
        {
            List<Localidad> localidades = new List<Localidad>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo, IdDepartamento FROM Localidades WHERE Activo = 1", connection))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var localidad = new Localidad
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                IdDepartamento = Convert.ToInt32(reader["IdDepartamento"])
                            };
                            localidades.Add(localidad);
                        }
                    }
                }
            }
            return localidades;
        }
        public int Insert(Localidad localidad)
        {
            int idInsertado = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "insert into Localidades (Nombre, Activo, IdDepartamento) values (@Nombre, @Activo, @IdDepartamento); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", localidad.Nombre);
                command.Parameters.AddWithValue("@Activo", localidad.Activo);
                command.Parameters.AddWithValue("@IdDepartamento", localidad.IdDepartamento);
                connection.Open();
                idInsertado = Convert.ToInt32(command.ExecuteScalar());
            }

            return idInsertado;
        }
        public IEnumerable<Localidad> GetByNombreLocalidad(string Nombre, int IdDepartamento)
        {
            List<Localidad> localidades = new List<Localidad>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo, IdDepartamento FROM Localidades WHERE Nombre = @Nombre", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var localidad = new Localidad
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                IdDepartamento = Convert.ToInt32(reader["IdDepartamento"])

                            };

                            localidades.Add(localidad);
                        }
                    }
                }
            }

            return localidades;
        }

        public bool Update(Localidad localidad)
        {
            bool resultado = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Localidades SET Nombre = @Nombre, IdDepartamento = @IdDepartamento WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", localidad.Nombre);
                command.Parameters.AddWithValue("@IdDepartamento", localidad.IdDepartamento);
                command.Parameters.AddWithValue("@Id", localidad.Id);

                connection.Open();
                resultado = command.ExecuteNonQuery() == 1 ? true : false;
            }
            return resultado;
        }

        public bool Delete(int id)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Localidades WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                result = rowsAffected == 1;
            }
            return result;
        }

        public bool Desactivar(int id)
        {
            bool resultado = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Localidades SET Activo = 0 WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                resultado = command.ExecuteNonQuery() == 1 ? true : false;
            }
            return resultado;
        }

        public bool Activar(int id)
        {
            bool resultado = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Localidades SET Activo = 1 WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                resultado = command.ExecuteNonQuery() == 1 ? true : false;
            }
            return resultado;
        }
    }
}

