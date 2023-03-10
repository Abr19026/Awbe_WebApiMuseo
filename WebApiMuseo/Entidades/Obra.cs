using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiMuseo.Entidades
{
    public class Obra
    {
        public int Id { get; set; }    //Primary key
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_creacion { get; set; }

        public int ExposicionId { get; set; }       // Foreign Key Expo
        public Exposicion exposicion { get; set; }  // ================
        public tipoObra tipo { get; set; }
        public ObraCine obraCine { get; set; }  // Foreign key Obra de cine
        public ObraPintura obraPintura { get; set; } // Foreign key Pintura
        public List<Sala> Salas { get; set; }   // Muchos a Muchos
    }

    public enum tipoObra
    {
        Cine,
        Pintura
    }
}
