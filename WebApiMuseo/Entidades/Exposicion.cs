namespace WebApiMuseo.Entidades
{
    public class Exposicion
    {
        public string Id { get; set; }   //Primary key
        public string Nombre { get; set; }
        public string Descripcion { get;}
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }

        public List<Obra> Obras { get; set; }
    }
}
