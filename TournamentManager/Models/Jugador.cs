using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentManager.Models
{
    public class Jugador
    {
        // Identidad
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string? Nombre { get; set; }

        [Required, StringLength(20)]
        public string? Nick { get; set; }

        [Required, StringLength(50)]
        public string? Pais { get; set; }

        [Range(13, 60)]
        public int Edad { get; set; }

        // Estadísticas acumuladas (Totales históricos)
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int GolesTotales { get; set; }
        public int AsistenciasTotales { get; set; }
        public int SalvadasTotales { get; set; }
        public int MVPsTotales { get; set; }

        // Estadísticas calculadas (Ratios)
        [NotMapped]
        public double Winrate =>
            PartidosJugados == 0 ? 0 :
            Math.Round((double)PartidosGanados / PartidosJugados * 100, 2);

        // Goles por Partido
        [NotMapped]
        public double GolesPorPartido =>
            PartidosJugados == 0 ? 0 :
            Math.Round((double)GolesTotales / PartidosJugados, 2);

        // Relaciones

        // Equipo al que pertenece
        public int EquipoId { get; set; }
        public Equipo? Equipo { get; set; }

        // Historial de partidos (Relación con la nueva tabla)
        public ICollection<PartidoJugador> HistorialPartidos { get; set; } = new List<PartidoJugador>();
    }
}