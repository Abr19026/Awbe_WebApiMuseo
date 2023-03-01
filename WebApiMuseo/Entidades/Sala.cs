namespace WebApiMuseo.Entidades
{
    public class Sala
    {
        public int id;

        public string nombre;

        public Tipo_sala tipo;
    }

    public enum Tipo_sala
    {
        Auditorio,
        SalaCine,
        Salon,
        Explanada
    }
}
