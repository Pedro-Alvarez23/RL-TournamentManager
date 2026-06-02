using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TournamentManager.Models
{
    public class Partido
    {
        //Identidad
        public int Id { get; set; }
        public bool Jugado { get; set; } = false;

        public int? MVPJugadorId { get; set; }
        public Jugador? MVPJugador { get; set; }


        //Relaciones
        [Required]
        public int RondaId { get; set; }
        public Ronda? Ronda { get; set; }               

        public ICollection<EquipoPartido> Equipos { get; set; } = new List<EquipoPartido>();

        // He estado con el chati para ver si lo podemos poner aqui también, no mapped pero asi podemos hacer la consulta desde el partido
        // Ganador calculado
        [NotMapped]
        public Equipo? Ganador

        {
            get
            {
                if (!Jugado ||Equipos.Count != 2)
                    return null;

                return Equipos
                    .OrderByDescending(e => e.Goles)
                    .First()
                    .Equipo;
            }
        }
        // Perdedor calc.
        [NotMapped]
        public Equipo? Perdedor
        {
            get
            {
                if (Equipos.Count != 2)
                    return null;

                return Equipos
                    .OrderBy(e => e.Goles)
                    .First()
                    .Equipo;
            }
        }

    }
}
