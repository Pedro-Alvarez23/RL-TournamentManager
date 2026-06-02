using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentManager.Models
{
    public class Equipo
    {
        //Identidad

        public int Id { get; set; }

        [Required, StringLength(50)]
        public string? Nombre { get; set; }

        [Required, StringLength(10)]
        public string? Tag { get; set; }

        [Required, StringLength(50)]
        public string? Pais { get; set; }

        // Ruta o URL del logo(esto no se si hacerlo de otra manera)
        public string? Logo { get; set; }

        //Estadísticas acumuladas
        // Se actualizan automáticamente desde los partidos

        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }

        public int GolesAFavor { get; set; }
        public int GolesEnContra { get; set; }
        public int TitulosGanados { get; set; }

        //Estadísticas calculadas
        [NotMapped]
        public double Winrate =>
            PartidosJugados == 0 ? 0 :
            Math.Round((double)PartidosGanados / PartidosJugados * 100, 2);

        [NotMapped]
        public int DiferenciaGoles =>
            GolesAFavor - GolesEnContra;

        //Relaciones

        public ICollection<Jugador> Jugadores { get; set; } = new List<Jugador>();

        public ICollection<EquipoPartido> Partidos { get; set; } = new List<EquipoPartido>();
        public ICollection<EquipoTorneo> Torneos { get; set; } = new List<EquipoTorneo>();
    }
}
