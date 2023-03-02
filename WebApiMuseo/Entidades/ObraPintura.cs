namespace WebApiMuseo.Entidades
{
    public class ObraPintura
    {
        public int Id { get; set; }
        public Persona Pintor { get; set; }
        public Tecnica tecnica { get; set; }
    }

    public enum Tecnica
    {
        oleo,
        acrilico,
        grafito,
        acuarela
    }
}
