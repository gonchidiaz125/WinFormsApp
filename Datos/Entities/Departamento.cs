namespace Datos.Entities
{
    public class Departamento   
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public int IdProvincia { get; set; }

        public Departamento()
        {
            Nombre = string.Empty;
        }
    }
}
