using System.ComponentModel.DataAnnotations;

namespace TournamentManager.Models
{
    public class Ronda
    {
            //Identidad
            public int Id { get; set; }

            // Yo aqui no pondría nada de equipos, las rondas tienen partidos no equipos. Para saberlo lo hacemos con una query:
            // Query:
            // var equiposClasificados = context.Partidos
            //.Where(p => p.RondaId == rondaId)
            //.SelectMany(p => p.Equipos)
            //.Where(ep => ep.EsGanador)
            //.Select(ep => ep.Equipo)
            //.ToList();


        ////Equipos clasificados (después de la ronda)
        //public ICollection<Equipo> EquiposClasificados { get; set; } = new List<Equipo>();
        ////quizas habria que hacer otra lista con todos los equipos de la ronda?

        [Required, StringLength(50)]
            public string? Nombre { get; set; }

            //Relaciones
            public ICollection<Partido> Partidos { get; set; } = new List<Partido>();

            [Required]
            public int TorneoId { get; set; }
            public Torneo? Torneo { get; set; }



    }
}
