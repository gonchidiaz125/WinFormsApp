namespace Datos.Entities
{
    public class Localidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public int IdDepartamento { get; set; }

        public Localidad()
        {
            Nombre = string.Empty;
        }
    }
}