using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentManager.Models
{
    public enum EstadoTorneo
    {
        Pendiente,//A lo mejor quitaria este estado. MEJOR lo mantendría, por si está creado pero no empezado...
        EnCurso,
        Finalizado
    }
    public class Torneo
    {
        //Identidad

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string? Nombre { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [Required]
        public EstadoTorneo Estado { get; set; }

        // Esto lo quitamos, he estado mirando y no tiene sentido que limitemos esto aqui, esto hay que limitarlo en el servicio
        //public int NumeroRondas { get; set; } = 4;

        public int? CampeonId { get; set; }
        public Equipo? Campeon { get; set; }

        public int? MVPId { get; set; }
        public Jugador? MVP { get; set; }


        // Yo esto no lo guardaria en bbdd, lo haria desde una query.
        // Query:
        // var golesTotales = context.EquipoPartidos
        //.Where(ep => ep.Partido.Ronda.TorneoId == torneoId)
        //.Sum(ep => ep.Goles);

        ////Estadísticas acumuladas
        //public int GolesTotales { get; set; }

        //Relaciones

        public ICollection<Ronda> Rondas { get; set; } = new List<Ronda>();

        public ICollection<EquipoTorneo>? Equipos { get; set; }

    }
}
