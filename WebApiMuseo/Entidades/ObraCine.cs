namespace WebApiMuseo.Entidades
{
    public class ObraCine
    {
        public int Id { get; set; }
        public Persona director { get; set; }
        public Persona escritor { get; set; }
        public int duracion { get; set; }
        public Genero genero { get; set; }
    }

    public enum Genero
    {
        Comedia,
        Terror,
        Documental,
        Acción
    }
}
