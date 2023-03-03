namespace WebApiMuseo.Entidades
{
    public class Exposicion
    {
        public int Id { get; set; }   //Primary key
        public string Nombre { get; set; }
        public string Descripcion { get;}
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public List<Obra> Obras { get; set; }
    }
}
