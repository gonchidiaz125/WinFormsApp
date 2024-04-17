namespace Datos.Entities
{
	public class Provincia
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public bool Activo { get; set; }

		public Provincia()
		{
			Nombre = string.Empty;
		}
	}
}
