using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiMuseo.Entidades
{
    public class ObraPintura
    {
        public int Id { get; set; }

        public int PintorId { get; set; }     // Foreign key Pintor
        [ForeignKey("PintorId")]
        public Persona Pintor { get; set; }   // ==================
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
