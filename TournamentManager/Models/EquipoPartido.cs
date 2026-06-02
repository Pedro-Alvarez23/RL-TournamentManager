using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentManager.Models
{
    public class EquipoPartido
    {
        [Key]
        public int Id { get; set; }
        //a lo mejor ganador deberia ir en partido?
        // No, veo bien que vaya aqui, pero no es necesario que sea un tipo equipo, creo que con que sea bool vale

        // Apuntar los goles por equipo
        [Required]
        public int Goles { get; set; }

        // Mejor que sea calculado
        [NotMapped]
        public bool Ganador => Goles == Partido!.Equipos.Max(e => e.Goles);

        // Relaciones
        [Required]
        public int EquipoId { get; set; }
        public Equipo? Equipo { get; set; }

        [Required]
        public int PartidoId { get; set; }
        public Partido? Partido { get; set; }

        // Relacion con los jugadores que han participado
        public ICollection<PartidoJugador> EstadisticasJugadores { get; set; } = new List<PartidoJugador>();
    }
}
