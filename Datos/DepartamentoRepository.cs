using Datos.Entities;
using System.Data.SqlClient;

namespace Datos
{
    public class DepartamentoRepository
    {
        string connectionString = "Server=localhost;Database=TestGonchi;Trusted_Connection=True;MultipleActiveResultSets=true";

        public Departamento Get(int id)
        {
            Departamento departamento = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo, IdProvincia FROM Departamentos WHERE Id=@Id", connection))
                {
                    command.Parameters.AddWithValue("id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            departamento = new Departamento
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                IdProvincia = Convert.ToInt32(reader["IdProvincia"])
                            };
                        }
                    }
                }
            }
            return departamento;
        }
        public IEnumerable<Departamento> Get()
        {
            List<Departamento> departamentos = new List<Departamento>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo, IdProvincia FROM Departamentos", connection))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var departamento = new Departamento
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                IdProvincia = Convert.ToInt32(reader["IdProvincia"])
                            };
                            departamentos.Add(departamento);
                        }
                    }
                }
            }
            return departamentos;
        }
        public IEnumerable<Departamento> GetActivas()
        {
            List<Departamento> departamentos = new List<Departamento>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo, IdProvincia FROM Departamentos WHERE Activo = 1", connection))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var departamento = new Departamento
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                IdProvincia = Convert.ToInt32(reader["IdProvincia"])
                            };
                            departamentos.Add(departamento);
                        }
                    }
                }
            }
            return departamentos;
        }
        public int Insert(Departamento departamento)
        {
            int idInsertado = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "insert into Departamentos (Nombre, Activo, IdProvincia) values (@Nombre, @Activo, @IdProvincia); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", departamento.Nombre);
                command.Parameters.AddWithValue("@Activo", departamento.Activo);
                command.Parameters.AddWithValue("@IdProvincia", departamento.IdProvincia);
                connection.Open();
                idInsertado = Convert.ToInt32(command.ExecuteScalar());
            }

            return idInsertado;
        }
        public IEnumerable<Departamento> GetByNombreDepartamento(string Nombre)
        {
            List<Departamento> departamentos = new List<Departamento>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo, IdProvincia FROM Departamentos WHERE Nombre = @Nombre", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", Nombre);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var departamento = new Departamento
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                IdProvincia = Convert.ToInt32(reader["IdProvincia"])
                            };

                            departamentos.Add(departamento);
                        }
                    }
                }
            }

            return departamentos;
        }

        public bool Update(Departamento departamento)
        {
            bool resultado = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Departamentos SET Nombre = @Nombre, IdProvincia = @IdProvincia WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", departamento.Nombre);
                command.Parameters.AddWithValue("@IdProvincia", departamento.IdProvincia);
                command.Parameters.AddWithValue("@Id", departamento.Id);
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
                string query = "DELETE FROM Departamentos WHERE Id = @Id";
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
                string query = "UPDATE Departamentos SET Activo = 0 WHERE Id = @Id";
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
                string query = "UPDATE Departamentos SET Activo = 1 WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                resultado = command.ExecuteNonQuery() == 1 ? true : false;
            }
            return resultado;
        }

    }
}
