namespace WebApiMuseo.Entidades
{
    public class Obra
    {
        public int Id { get; set; }    //Primary key
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public DateOnly fecha_creacion { get; set; }

        //Foreign keys exposicion, numero pintura, numero obra

    }
}
