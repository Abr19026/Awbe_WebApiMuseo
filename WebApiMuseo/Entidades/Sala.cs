namespace WebApiMuseo.Entidades
{
    public class Sala
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Tipo_sala tipo { get; set; }
        public List<Obra> Obras { get; set; } //Muchos a Muchos
    }

    public enum Tipo_sala
    {
        Auditorio,
        Salon,
        Explanada
    }
}
