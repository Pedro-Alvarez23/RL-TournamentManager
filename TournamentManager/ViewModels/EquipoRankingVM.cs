using TournamentManager.Models;

namespace TournamentManager.ViewModels
{
    public class EquipoRankingVM
    {
        // El objeto base por si necesitamos nombre, escudo, id...
        public Equipo Equipo { get; set; } = null!;

        // Datos crudos (que rellenamos desde la Base de Datos)
        public int Jugados => Equipo.PartidosJugados;
        public int Victorias { get; set; }
        public int GolesFavor { get; set; }

        // --- PROPIEDADES CALCULADAS (Magia del ViewModel) ---
        
        public int Derrotas => Jugados - Victorias;

        public double Winrate => Jugados == 0 ? 0 :
            Math.Round((double)Victorias / Jugados * 100, 1);

        public double GolesPorPartido => Jugados == 0 ? 0 :
            Math.Round((double)GolesFavor / Jugados, 2);

        // Incluso puedes poner lógica de diseño aquí
        public string WinrateColorClass => Winrate >= 50 ? "text-success" : "text-danger";
    }
}