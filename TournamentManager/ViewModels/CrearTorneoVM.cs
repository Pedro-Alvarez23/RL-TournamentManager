namespace TournamentManager.ViewModels
{
    public class CrearTorneoVM
    {
        public string? Nombre { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Today;

        public int? QF1 { get; set; }
        public int? QF2 { get; set; }
        public int? QF3 { get; set; }
        public int? QF4 { get; set; }
        public int? QF5 { get; set; }
        public int? QF6 { get; set; }
        public int? QF7 { get; set; }
        public int? QF8 { get; set; }
    }
}
