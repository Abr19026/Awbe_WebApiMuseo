using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiMuseo.Entidades
{
    public class ObraCine
    {
        public int Id { get; set; }
        
        
        [ForeignKey("directorId")]
        public Persona director { get; set; }    // ====================
        public int directorId { get; set; }      // Foreign key director


        [ForeignKey("escritorId")]
        public Persona escritor { get; set; }    // ====================
        public int escritorId { get; set; }      // Foreign key escritor

        public int duracion { get; set; }
        public GeneroCine genero { get; set; }
    }

    public enum GeneroCine
    {
        Comedia,
        Terror,
        Documental,
        Acción
    }
}
