using System.ComponentModel.DataAnnotations;

namespace TournamentManager.Models
{
    // Podriamos hacer que en vez de el bool de eliminado sea un estado, asi si hay un torneo en curso se ve...
    public enum EstadoParticipacion
    {
        EnCompeticion,
        Eliminado,
        Campeon
    }
    public class EquipoTorneo
    {
        [Key]
        public int Id { get; set; }

        // Relaciones
        [Required]
        public int EquipoId { get; set; }
        public Equipo? Equipo { get; set; }

        [Required]
        public int TorneoId { get; set; }
        public Torneo? Torneo { get; set; }

        // Datos de la participación
        public int? PosicionFinal { get; set; }

        public EstadoParticipacion Estado { get; set; }
        //public bool Eliminado { get; set; }
    }
}
