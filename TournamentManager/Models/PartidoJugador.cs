using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentManager.Models
{
    public class PartidoJugador
    {
        [Key]
        public int Id { get; set; }

        // Estadísticas de ese partido específico para ese jugador
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int Salvadas { get; set; }

        public int Puntuacion { get; set; }

        // Relaciones
        [Required]
        public int EquipoPartidoId { get; set; }
        public EquipoPartido? EquipoPartido { get; set; }

        [Required]
        public int JugadorId { get; set; }
        public Jugador? Jugador { get; set; }
    }
}