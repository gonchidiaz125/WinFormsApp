using Datos.Entities;
using System.Data.SqlClient;


namespace Datos
{
	public class ProvinciaRepository
	{
		string connectionString = "Server=localhost;Database=TestGonchi;Trusted_Connection=True;MultipleActiveResultSets=true";

		public Provincia Get(int id)
		{
			Provincia provincia = null;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo FROM Provincias WHERE Id=@Id", connection))
				{
					command.Parameters.AddWithValue("id", id);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							provincia = new Provincia
							{
								Id = Convert.ToInt32(reader["Id"]),
								Nombre = Convert.ToString(reader["Nombre"]),
								Activo = Convert.ToBoolean(reader["Activo"])
							};
						}
					}
				}
			}
			return provincia;
		}

		public IEnumerable<Provincia> Get()
		{
			List<Provincia> provincias = new List<Provincia>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo FROM Provincias ORDER BY Nombre", connection))
				{


					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var provincia = new Provincia
							{
								Id = Convert.ToInt32(reader["Id"]),
								Nombre = Convert.ToString(reader["Nombre"]),
								Activo = Convert.ToBoolean(reader["Activo"])
							};
							provincias.Add(provincia);
						}
					}
				}
			}
			return provincias;
		}

		public IEnumerable<Provincia> GetActivas()
		{
			List<Provincia> provincias = new List<Provincia>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo FROM Provincias WHERE Activo = 1", connection))
				{


					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var provincia = new Provincia
							{
								Id = Convert.ToInt32(reader["Id"]),
								Nombre = Convert.ToString(reader["Nombre"]),
								Activo = Convert.ToBoolean(reader["Activo"])
							};
							provincias.Add(provincia);
						}
					}
				}
			}
			return provincias;
		}

		public int Insert(Provincia provincia)
		{
			int idInsertado = 0;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "insert into Provincias (Nombre, Activo) values (@Nombre, @Activo); SELECT SCOPE_IDENTITY();";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@Nombre", provincia.Nombre);
				command.Parameters.AddWithValue("@Activo", provincia.Activo);
				connection.Open();
				idInsertado = Convert.ToInt32(command.ExecuteScalar());
			}

			return idInsertado;
		}
		public IEnumerable<Provincia> GetByNombreProvincia(string Nombre)
		{
			List<Provincia> provincias = new List<Provincia>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand("SELECT Id, Nombre, Activo FROM Provincias WHERE Nombre = @Nombre", connection))
				{
					command.Parameters.AddWithValue("@Nombre", Nombre);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var provincia = new Provincia
							{
								Id = Convert.ToInt32(reader["Id"]),
								Nombre = Convert.ToString(reader["Nombre"]),
								Activo = Convert.ToBoolean(reader["Activo"])
							};

							provincias.Add(provincia);
						}
					}
				}
			}

			return provincias;
		}
		public bool Update(Provincia provincia)
		{
			bool resultado = false;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "UPDATE Provincias SET Nombre = @Nombre, Activo = @Activo WHERE Id = @Id";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@Nombre", provincia.Nombre);
				command.Parameters.AddWithValue("@Activo", provincia.Activo);
				command.Parameters.AddWithValue("@Id", provincia.Id);
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
				string query = "DELETE FROM Provincias WHERE Id = @Id";
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
				string query = "UPDATE Provincias SET Activo = 0 WHERE Id = @Id";
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
				string query = "UPDATE Provincias SET Activo = 1 WHERE Id = @Id";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@Id", id);
				connection.Open();
				resultado = command.ExecuteNonQuery() == 1 ? true : false;
			}
			return resultado;
		}



	}
}
