using Microsoft.EntityFrameworkCore;
using TournamentManager.Models;

namespace TournamentManager.Data
{
    public class TournamentDbContext : DbContext
    {
        public TournamentDbContext(DbContextOptions<TournamentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; } = null!;
        public DbSet<Jugador> Jugadores { get; set; } = null!;
        public DbSet<Torneo> Torneos { get; set; } = null!;
        public DbSet<Ronda> Rondas { get; set; } = null!;
        public DbSet<Partido> Partidos { get; set; } = null!;
        public DbSet<EquipoPartido> EquipoPartidos { get; set; } = null!;
        public DbSet<EquipoTorneo> EquipoTorneos { get; set; } = null!;
        public DbSet<PartidoJugador> PartidoJugadores { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ----------------------------
            // Relaciones Equipo - Jugador
            // ----------------------------
            modelBuilder.Entity<Jugador>()
                .HasOne(j => j.Equipo)
                .WithMany(e => e.Jugadores)
                .HasForeignKey(j => j.EquipoId)
                .OnDelete(DeleteBehavior.Restrict);

            // ----------------------------
            // Relaciones Torneo - Ronda
            // ----------------------------
            modelBuilder.Entity<Ronda>()
                .HasOne(r => r.Torneo)
                .WithMany(t => t.Rondas)
                .HasForeignKey(r => r.TorneoId)
                .OnDelete(DeleteBehavior.Cascade);

            // ----------------------------
            // Relaciones Ronda - Partido
            // ----------------------------
            modelBuilder.Entity<Partido>()
                .HasOne(p => p.Ronda)
                .WithMany(r => r.Partidos)
                .HasForeignKey(p => p.RondaId)
                .OnDelete(DeleteBehavior.Cascade);

            // ----------------------------
            // Relaciones EquipoPartido (tabla intermedia)
            // ----------------------------
            modelBuilder.Entity<EquipoPartido>()
                .HasOne(ep => ep.Equipo)
                .WithMany(e => e.Partidos)
                .HasForeignKey(ep => ep.EquipoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EquipoPartido>()
                .HasOne(ep => ep.Partido)
                .WithMany(p => p.Equipos)
                .HasForeignKey(ep => ep.PartidoId)
                .OnDelete(DeleteBehavior.Cascade);

            // ----------------------------
            // Relación PartidoJugador → EquipoPartido(muchos stats por un equipo en un partido)
            // ----------------------------
            modelBuilder.Entity<EquipoTorneo>()
                .HasOne(et => et.Equipo)
                .WithMany(e => e.Torneos)
                .HasForeignKey(et => et.EquipoId)
                .OnDelete(DeleteBehavior.Restrict);

            // ----------------------------
            // Relación: PartidoJugador → Jugador (muchos stats por un jugador)
            // ----------------------------
            modelBuilder.Entity<EquipoTorneo>()
                .HasOne(et => et.Torneo)
                .WithMany(t => t.Equipos)
                .HasForeignKey(et => et.TorneoId)
                .OnDelete(DeleteBehavior.Cascade);

            // ----------------------------
            // Relaciones Torneo → Campeon (Equipo) y MVP (Jugador)
            // ----------------------------
            modelBuilder.Entity<Torneo>()
                .HasOne(t => t.Campeon)
                .WithMany() // sin navegación inversa
                .HasForeignKey(t => t.CampeonId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Torneo>()
                .HasOne(t => t.MVP)
                .WithMany() // sin navegación inversa
                .HasForeignKey(t => t.MVPId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PartidoJugador>()
                .HasOne(pj => pj.EquipoPartido)
                .WithMany(ep => ep.EstadisticasJugadores)
                .HasForeignKey(pj => pj.EquipoPartidoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PartidoJugador>()
                .HasOne(pj => pj.Jugador)
                .WithMany(j => j.HistorialPartidos)
                .HasForeignKey(pj => pj.JugadorId)
                .OnDelete(DeleteBehavior.Cascade);


            // ==========================
            // EQUIPOS
            // ==========================
            modelBuilder.Entity<Equipo>().HasData(
                new Equipo { 
                    Id = 1, Nombre = "Team BDS", PartidosJugados = 4, PartidosGanados = 2, GolesAFavor=10, GolesEnContra=14, TitulosGanados=0,
                    Tag = "BDS", Pais = "FR", Logo = "https://upload.wikimedia.org/wikipedia/fr/6/61/Team_BDS.png" },
                new Equipo { 
                    Id = 2, Nombre = "G2 Stride", PartidosJugados=5, PartidosGanados=3, GolesAFavor=16,GolesEnContra=13, TitulosGanados=1,
                    Tag = "G2", Pais = "USA", Logo = "https://cdn.fifa.gg/cache/media/team_emblem/51c3f5a8-f4e3-42f7-8793-a23806b9d41e/Emblem-of-team-G2-Stride-team_emblem-51c3f5a8-f4e3-42f7-8793-a23806b9d41e.png?" },
                new Equipo { 
                    Id = 3, Nombre = "Karmine Corp", PartidosJugados=6, PartidosGanados=4, GolesAFavor=21,GolesEnContra=12,TitulosGanados=1,
                    Tag = "KARM", Pais = "FR", Logo = "https://upload.wikimedia.org/wikipedia/commons/9/96/Karmine_Corp_logo.svg" },
                new Equipo { 
                    Id = 4, Nombre = "Team Falcons", PartidosJugados = 4, PartidosGanados =2, GolesAFavor = 10, GolesEnContra =11, TitulosGanados =0,
                    Tag = "FAL", Pais = "MENA", Logo = "https://cdn.freebiesupply.com/images/thumbs/2x/atlanta-falcons-logo.png" },
                new Equipo { 
                    Id = 5, Nombre = "FURIA Esports",
                    PartidosJugados = 2,
                    PartidosGanados =0,
                    GolesAFavor = 5,
                    GolesEnContra =8,
                    TitulosGanados =0,
                    Tag = "FUR", Pais = "BR", Logo = "https://vectorseek.com/wp-content/uploads/2023/04/Furia-Esports-Logo-Vector.jpg" },
                new Equipo { 
                    Id = 6, Nombre = "Oxygen Esports",
                    PartidosJugados = 5,
                    PartidosGanados =2,
                    GolesAFavor = 14,
                    GolesEnContra =16,
                    TitulosGanados =0,
                    Tag = "OXG", Pais = "USA", Logo = "https://esportsinsider.com/wp-content/uploads/2023/07/oxygen-esports-new-logo-new.png" },
                new Equipo { 
                    Id = 7, Nombre = "Gentle Mates Alpine",
                    PartidosJugados = 5,
                    PartidosGanados =3,
                    GolesAFavor = 15,
                    GolesEnContra =16,
                    TitulosGanados =0,
                    Tag = "GMA", Pais = "EU", Logo = "https://upload.wikimedia.org/wikipedia/commons/b/be/Gentle_Mates_2025.png" },
                new Equipo { 
                    Id = 8, Nombre = "Spacestation Gaming",
                    PartidosJugados = 0,
                    PartidosGanados =0,
                    GolesAFavor = 0,
                    GolesEnContra =0,
                    TitulosGanados =0,
                    Tag = "SSG", Pais = "USA", Logo = "https://cdn.prod.website-files.com/605e2c8c6b591c8ec12559d4/67db0453ffa840b313729e7f_1000x1000.png" },

                new Equipo { 
                    Id = 9, Nombre = "NRG Esports",
                    PartidosJugados = 3,
                    PartidosGanados =1,
                    GolesAFavor = 7,
                    GolesEnContra =10,
                    TitulosGanados =0,
                    Tag = "NRG", Pais = "USA", Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQn2Cur13GkniLAl7dqZrfKjvKo3LH0iO9P5A&s" },
                new Equipo { 
                    Id = 10, Nombre = "Geekay Esports",
                    PartidosJugados = 0,
                    PartidosGanados =0,
                    GolesAFavor = 0,
                    GolesEnContra =0,
                    TitulosGanados =0,
                    Tag = "GKAY", Pais = "EU", Logo = "https://distribution.faceit-cdn.net/images/e146675f-058d-468a-a9be-4640caaaf09a.jpg" },
                new Equipo { 
                    Id = 11, Nombre = "The Ultimates",
                    PartidosJugados = 0,
                    PartidosGanados =0,
                    GolesAFavor = 0,
                    GolesEnContra =0,
                    TitulosGanados =0,
                    Tag = "ULT", Pais = "NA", Logo = "https://images.squarespace-cdn.com/content/v1/531ced34e4b0f6dda98cdae8/1395639361432-7DQAQN747X1H99QTKFIN/KyleChristianDesign_Logo_UFC_Ultimates_4C.jpg?format=1500w" },
                new Equipo { 
                    Id = 12, Nombre = "Wildcard",
                    PartidosJugados = 0,
                    PartidosGanados =0,
                    GolesAFavor = 0,
                    GolesEnContra =0,
                    TitulosGanados =0,
                    Tag = "WC", Pais = "OCE", Logo = "https://www.clipartmax.com/png/middle/100-1001205_wildcard-gaminglogo-square-wildcard-gaming.png" },
                new Equipo { 
                    Id = 13, Nombre = "Ninjas in Pyjamas",
                    PartidosJugados = 1,
                    PartidosGanados =0,
                    GolesAFavor = 1,
                    GolesEnContra =4,
                    TitulosGanados =0,
                    Tag = "NIP", Pais = "EU", Logo = "https://images.seeklogo.com/logo-png/55/2/ninjas-in-pyjamas-logo-png_seeklogo-550433.png"                },
                new Equipo { 
                    Id = 14, Nombre = "Team Vitality",
                    PartidosJugados = 6,
                    PartidosGanados =4,
                    GolesAFavor = 21,
                    GolesEnContra =13,
                    TitulosGanados =1,
                    Tag = "VIT", Pais = "FR", Logo = "https://www.vhv.rs/dpng/d/487-4879695_team-vitality-cs-team-vitality-logo-hd-png.png" },
                new Equipo { 
                    Id = 15, Nombre = "Team Secret",
                    PartidosJugados = 0,
                    PartidosGanados =0,
                    GolesAFavor = 0,
                    GolesEnContra =0,
                    TitulosGanados =0,
                    Tag = "SECR", Pais = "SAM", Logo = "https://upload.wikimedia.org/wikipedia/ru/archive/7/71/20230415191739%21Team_Secret_logo_notext.png" },
                new Equipo { 
                    Id = 16, Nombre = "Gen.G Mobil1 Racing",
                    PartidosJugados = 1,
                    PartidosGanados =0,
                    GolesAFavor = 2,
                    GolesEnContra =4,
                    TitulosGanados =0,
                    Tag = "GENG", Pais = "NA", Logo = "https://upload.wikimedia.org/wikipedia/commons/7/77/Gen.G_Logo.svg" }
            );

            // ==========================
            // JUGADORES
            // (ROSTERS CONFIRMADOS RLCS 2024 & 2025)
            // ==========================
            modelBuilder.Entity<Jugador>().HasData(
                // Team BDS (2024)
                new Jugador { Id = 1, Nombre = "Evan \"M0nkey M00n\" Rogez", Nick = "M0nkeyM00n", Pais = "FR", Edad = 23, EquipoId = 1,
                    PartidosJugados = 4, PartidosGanados= 2, GolesTotales=5, AsistenciasTotales=0, SalvadasTotales=10, MVPsTotales=1
                },
                new Jugador { Id = 2, Nombre = "Brice \"ExoTiiK\" Bigeard", Nick = "ExoTiiK", Pais = "FR", Edad = 24, EquipoId = 1,
                    PartidosJugados = 4,
                    PartidosGanados = 2,
                    GolesTotales =2,
                    AsistenciasTotales =2,
                    SalvadasTotales =5,
                    MVPsTotales = 0
                },
                new Jugador { Id = 3, Nombre = "Alexis \"zen\" Bernier", Nick = "zen", Pais = "FR", Edad = 24, EquipoId = 1,
                    PartidosJugados = 4,
                    PartidosGanados = 2,
                    GolesTotales =3,
                    AsistenciasTotales =2,
                    SalvadasTotales =4,
                    MVPsTotales =1
                },

                // G2 Stride (2024)
                new Jugador { Id = 4, Nombre = "Atomic", Nick = "Atomic", Pais = "USA", Edad = 23, EquipoId = 2,
                    PartidosJugados = 5,
                    PartidosGanados = 3,
                    GolesTotales =5,
                    AsistenciasTotales =5,
                    SalvadasTotales =8,
                    MVPsTotales =1
                },
                new Jugador { Id = 5, Nombre = "Landon \"BeastMode\" Konerman", Nick = "BeastMode", Pais = "USA", Edad = 22, EquipoId = 2,
                    PartidosJugados = 5,
                    PartidosGanados = 3,
                    GolesTotales =9,
                    AsistenciasTotales =1,
                    SalvadasTotales =7,
                    MVPsTotales =2
                },
                new Jugador { Id = 6, Nombre = "Daniel", Nick = "Daniel", Pais = "USA", Edad = 20, EquipoId = 2,
                    PartidosJugados = 5,
                    PartidosGanados = 3,
                    GolesTotales =2,
                    AsistenciasTotales =5,
                    SalvadasTotales =6,
                    MVPsTotales = 0
                },

                // Karmine Corp (2024 & 2025)
                new Jugador { Id = 7, Nombre = "Vatira", Nick = "Vatira", Pais = "BE", Edad = 25, EquipoId = 3,
                    PartidosJugados = 6,
                    PartidosGanados = 4,
                    GolesTotales =10,
                    AsistenciasTotales =5,
                    SalvadasTotales =13,
                    MVPsTotales =2
                },
                new Jugador { Id = 8, Nombre = "Atow", Nick = "Atow", Pais = "BE", Edad = 24, EquipoId = 3,
                    PartidosJugados = 6,
                    PartidosGanados = 4,
                    GolesTotales =6,
                    AsistenciasTotales =5,
                    SalvadasTotales =8,
                    MVPsTotales =1
                },
                new Jugador { Id = 9, Nombre = "dralii", Nick = "dralii", Pais = "FR", Edad = 21, EquipoId = 3,
                    PartidosJugados = 6,
                    PartidosGanados = 4,
                    GolesTotales =5,
                    AsistenciasTotales =2,
                    SalvadasTotales =6,
                    MVPsTotales =1
                },

                // Team Falcons (2024 & 2025)
                new Jugador { Id = 10, Nombre = "Trk511", Nick = "Trk511", Pais = "SA", Edad = 20, EquipoId = 4,
                    PartidosJugados = 4,
                    PartidosGanados = 2,
                    GolesTotales =5,
                    AsistenciasTotales =0,
                    SalvadasTotales =10,
                    MVPsTotales =2
                },
                new Jugador { Id = 11, Nombre = "Rw9", Nick = "Rw9", Pais = "SA", Edad = 21, EquipoId = 4,
                    PartidosJugados = 4,
                    PartidosGanados = 2,
                    GolesTotales =2,
                    AsistenciasTotales =3,
                    SalvadasTotales =6,
                    MVPsTotales =0
                },
                new Jugador { Id = 12, Nombre = "Kiileerrz", Nick = "Kiileerrz", Pais = "SA", Edad = 22, EquipoId = 4,
                    PartidosJugados = 4,
                    PartidosGanados = 2,
                    GolesTotales =3,
                    AsistenciasTotales =0,
                    SalvadasTotales =4,
                    MVPsTotales =0
                },

                // FURIA Esports (2025)
                new Jugador { Id = 13, Nombre = "yANXNZ", Nick = "yANXNZ", Pais = "BR", Edad = 23, EquipoId = 5,
                    PartidosJugados = 2,
                    PartidosGanados = 0,
                    GolesTotales =2,
                    AsistenciasTotales =0,
                    SalvadasTotales =4,
                    MVPsTotales =0
                },
                new Jugador { Id = 14, Nombre = "Lostt", Nick = "Lostt", Pais = "BR", Edad = 24, EquipoId = 5,
                    PartidosJugados = 2,
                    PartidosGanados = 0,
                    GolesTotales =2,
                    AsistenciasTotales =2,
                    SalvadasTotales =2,
                    MVPsTotales =0
                },
                new Jugador { Id = 15, Nombre = "DRUFINHO", Nick = "DRUFINHO", Pais = "BR", Edad = 22, EquipoId = 5,
                    PartidosJugados = 2,
                    PartidosGanados = 0,
                    GolesTotales =1,
                    AsistenciasTotales =0,
                    SalvadasTotales =2,
                    MVPsTotales =0
                },

                // Oxygen Esports (2024) - MIX STREAMERS & CUSTOM
                new Jugador { Id = 16, Nombre = "Alfredo Blanco", Nick = "alfredbg333", Pais = "ES", Edad = 21, EquipoId = 6,
                    PartidosJugados = 5,
                    PartidosGanados = 2,
                    GolesTotales =9,
                    AsistenciasTotales =4,
                    SalvadasTotales =20,
                    MVPsTotales =2
                },
                new Jugador { Id = 17, Nombre = "Mariano Arruda", Nick = "SquishyMuffinz", Pais = "CA", Edad = 24, EquipoId = 6,
                    PartidosJugados = 5,
                    PartidosGanados = 2,
                    GolesTotales =3,
                    AsistenciasTotales =4,
                    SalvadasTotales =7,
                    MVPsTotales =0
                },
                new Jugador { Id = 18, Nombre = "Dillon Rizzo", Nick = "Rizzo", Pais = "USA", Edad = 27, EquipoId = 6,
                    PartidosJugados = 5,
                    PartidosGanados = 2,
                    GolesTotales =2,
                    AsistenciasTotales =4,
                    SalvadasTotales =6,
                    MVPsTotales =0
                },

                // Gentle Mates Alpine (2024)
                new Jugador { Id = 19, Nombre = "Juicy", Nick = "Juicy", Pais = "FR", Edad = 22, EquipoId = 7,
                    PartidosJugados = 5,
                    PartidosGanados = 3,
                    GolesTotales =8,
                    AsistenciasTotales =0,
                    SalvadasTotales =9,
                    MVPsTotales =2
                },
                new Jugador { Id = 20, Nombre = "Yujin", Nick = "Yujin", Pais = "KR", Edad = 23, EquipoId = 7,
                    PartidosJugados = 5,
                    PartidosGanados = 3,
                    GolesTotales =3,
                    AsistenciasTotales =5,
                    SalvadasTotales =7,
                    MVPsTotales =0
                },
                new Jugador { Id = 21, Nombre = "Seikoo", Nick = "Seikoo", Pais = "FR", Edad = 21, EquipoId = 7,
                    PartidosJugados = 5,
                    PartidosGanados = 3,
                    GolesTotales =4,
                    AsistenciasTotales =1,
                    SalvadasTotales =6,
                    MVPsTotales =1
                },

                // Spacestation Gaming (2024 & 2025)
                new Jugador { Id = 22, Nombre = "Scrzbbles", Nick = "Scrzbbles", Pais = "USA", Edad = 24, EquipoId = 8,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 23, Nombre = "reveal", Nick = "reveal", Pais = "USA", Edad = 23, EquipoId = 8,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 24, Nombre = "kofyr", Nick = "kofyr", Pais = "USA", Edad = 22, EquipoId = 8,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },

                // NRG Esports (2025)
                new Jugador { Id = 25, Nombre = "Garrett Gordon", Nick = "GarrettG", Pais = "USA", Edad = 24, EquipoId = 9,
                    PartidosJugados = 3,
                    PartidosGanados = 1,
                    GolesTotales =4,
                    AsistenciasTotales =0,
                    SalvadasTotales =6,
                    MVPsTotales =1
                },
                new Jugador { Id = 26, Nombre = "Justin Morales", Nick = "jstn.", Pais = "USA", Edad = 23, EquipoId = 9,
                    PartidosJugados = 3,
                    PartidosGanados = 1,
                    GolesTotales =2,
                    AsistenciasTotales =1,
                    SalvadasTotales =3,
                    MVPsTotales =0
                },
                new Jugador { Id = 27, Nombre = "Mariano Arruda", Nick = "Squishy", Pais = "CA", Edad = 24, EquipoId = 9,
                    PartidosJugados =3 ,
                    PartidosGanados = 1,
                    GolesTotales =1,
                    AsistenciasTotales =1,
                    SalvadasTotales =3,
                    MVPsTotales =0
                },

                // Geekay Esports (2025)
                new Jugador { Id = 28, Nombre = "Archie", Nick = "Archie", Pais = "EU", Edad = 24, EquipoId = 10,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 29, Nombre = "Joyo", Nick = "Joyo", Pais = "EU", Edad = 23, EquipoId = 10,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 30, Nombre = "Oaly", Nick = "Oaly", Pais = "EU", Edad = 22, EquipoId = 10,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },

                // The Ultimates (2025)
                new Jugador { Id = 31, Nombre = "Firstkiller", Nick = "Firstkiller", Pais = "NA", Edad = 25, EquipoId = 11,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 32, Nombre = "Lj", Nick = "Lj", Pais = "NA", Edad = 24, EquipoId = 11,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 33, Nombre = "Chronic", Nick = "Chronic", Pais = "NA", Edad = 23, EquipoId = 11,
                    PartidosJugados =0 ,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },

                // Wildcard (2025)
                new Jugador { Id = 34, Nombre = "Fever", Nick = "Fever", Pais = "OCE", Edad = 24, EquipoId = 12,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 35, Nombre = "Toros", Nick = "Toros", Pais = "OCE", Edad = 23, EquipoId = 12,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 36, Nombre = "Bananahead", Nick = "Bananahead", Pais = "OCE", Edad = 22, EquipoId = 12,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },

                // Ninjas in Pyjamas (2025) - SAM LEGENDS
                new Jugador { Id = 37, Nombre = "Luiz Fellipe", Nick = "AztromicK", Pais = "BR", Edad = 21, EquipoId = 13,
                    PartidosJugados = 1,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =2,
                    MVPsTotales =0
                },
                new Jugador { Id = 38, Nombre = "Bernardo Siqueira", Nick = "Bemmz", Pais = "BR", Edad = 22, EquipoId = 13,
                    PartidosJugados = 1,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =1,
                    MVPsTotales =0
                },
                new Jugador { Id = 39, Nombre = "Caio Vinicius", Nick = "CaioTG1", Pais = "BR", Edad = 25, EquipoId = 13,
                    PartidosJugados = 1,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =1,
                    MVPsTotales =0
                },

                // Team Vitality (Legendary/Classic)
                new Jugador { Id = 46, Nombre = "Yanis Champenois", Nick = "Alpha54", Pais = "FR", Edad = 22, EquipoId = 14,
                    PartidosJugados = 6,
                    PartidosGanados = 4,
                    GolesTotales =10,
                    AsistenciasTotales =5,
                    SalvadasTotales =8,
                    MVPsTotales =3
                },
                new Jugador { Id = 47, Nombre = "Andrea Radovanović", Nick = "Radosin", Pais = "FR", Edad = 21, EquipoId = 14,
                    PartidosJugados = 6,
                    PartidosGanados = 4,
                    GolesTotales =6,
                    AsistenciasTotales =3,
                    SalvadasTotales =10,
                    MVPsTotales =0
                },
                new Jugador { Id = 48, Nombre = "Victor Locquet", Nick = "Fairy Peak!", Pais = "FR", Edad = 26, EquipoId = 14,
                    PartidosJugados = 6,
                    PartidosGanados = 4,
                    GolesTotales =5,
                    AsistenciasTotales =4,
                    SalvadasTotales =6,
                    MVPsTotales =1
                },

                // Team Secret (2025)
                new Jugador { Id = 40, Nombre = "kv1", Nick = "kv1", Pais = "SAM", Edad = 23, EquipoId = 15,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 41, Nombre = "swiftt", Nick = "swiftt", Pais = "SAM", Edad = 24, EquipoId = 15,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },
                new Jugador { Id = 42, Nombre = "Motta", Nick = "Motta", Pais = "SAM", Edad = 22, EquipoId = 15,
                    PartidosJugados = 0,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =0,
                    SalvadasTotales =0,
                    MVPsTotales =0
                },

                // Gen.G Mobil1 Racing (2025)
                new Jugador { Id = 43, Nombre = "MaJicBear", Nick = "MaJicBear", Pais = "NA", Edad = 23, EquipoId = 16,
                    PartidosJugados = 1,
                    PartidosGanados =0 ,
                    GolesTotales =1,
                    AsistenciasTotales =0,
                    SalvadasTotales =2,
                    MVPsTotales =0
                },
                new Jugador { Id = 44, Nombre = "CHEESE.", Nick = "CHEESE.", Pais = "NA", Edad = 24, EquipoId = 16,
                    PartidosJugados = 1,
                    PartidosGanados = 0,
                    GolesTotales =1,
                    AsistenciasTotales =0,
                    SalvadasTotales =1,
                    MVPsTotales =0
                },
                new Jugador { Id = 45, Nombre = "Cristian", Nick = "crr", Pais = "ES", Edad = 22, EquipoId = 16,
                    PartidosJugados = 1,
                    PartidosGanados = 0,
                    GolesTotales =0,
                    AsistenciasTotales =1,
                    SalvadasTotales =1,
                    MVPsTotales =0
                }
            );

            // ==========================
            // TORNEOS (RLCS)
            // ==========================
            modelBuilder.Entity<Torneo>().HasData(
                new Torneo { Id = 1, Nombre = "RLCS 2023 World Championship", FechaInicio = new DateTime(2023, 8, 3), FechaFin = new DateTime(2023, 8, 13), Estado = EstadoTorneo.Finalizado, CampeonId = 14, MVPId = 46 },
                new Torneo { Id = 2, Nombre = "RLCS 2024 Major 1", FechaInicio = new DateTime(2024, 3, 28), FechaFin = new DateTime(2024, 3, 31), Estado = EstadoTorneo.Finalizado, CampeonId = 2, MVPId = 5 },
                new Torneo { Id = 3, Nombre = "RLCS 2025 Winter Split", FechaInicio = new DateTime(2025, 1, 15), FechaFin = new DateTime(2025, 1, 20), Estado = EstadoTorneo.Finalizado, CampeonId = 3, MVPId = 7 }
            );

            // ==========================
            // RONDAS
            // ==========================
            modelBuilder.Entity<Ronda>().HasData(
                // Torneo 1 (2023)
                new Ronda { Id = 10, Nombre = "Cuartos de Final", TorneoId = 1 },
                new Ronda { Id = 11, Nombre = "Semifinales", TorneoId = 1 },
                new Ronda { Id = 1, Nombre = "Gran Final", TorneoId = 1 },

                // Torneo 2 (2024)
                new Ronda { Id = 20, Nombre = "Cuartos de Final", TorneoId = 2 },
                new Ronda { Id = 21, Nombre = "Semifinales", TorneoId = 2 },
                new Ronda { Id = 2, Nombre = "Gran Final", TorneoId = 2 },

                // Torneo 3 (2025)
                new Ronda { Id = 30, Nombre = "Cuartos de Final", TorneoId = 3 },
                new Ronda { Id = 31, Nombre = "Semifinales", TorneoId = 3 },
                new Ronda { Id = 3, Nombre = "Gran Final", TorneoId = 3 }
            );

            // ==========================
            // PARTIDOS & EQUIPO-PARTIDOS
            // ==========================

            // --- TORNEO 1: RLCS 2023 ---
            modelBuilder.Entity<Partido>().HasData(
                // Cuartos
                new Partido { Id = 101, RondaId = 10, Jugado = true, MVPJugadorId = 46 }, // Vitality vs NRG
                new Partido { Id = 102, RondaId = 10, Jugado = true, MVPJugadorId = 16 }, // Oxygen vs Furia 
                new Partido { Id = 103, RondaId = 10, Jugado = true, MVPJugadorId = 1 },  // BDS vs G2
                new Partido { Id = 104, RondaId = 10, Jugado = true, MVPJugadorId = 7 },  // KC vs Falcons
                                                                                          // Semis
                new Partido { Id = 105, RondaId = 11, Jugado = true, MVPJugadorId = 46 }, // Vitality vs Oxygen
                new Partido { Id = 106, RondaId = 11, Jugado = true, MVPJugadorId = 1 },  // BDS vs KC
                                                                                          // Final
                new Partido { Id = 1, RondaId = 1, Jugado = true, MVPJugadorId = 46 }     // Vitality vs BDS
            );

            modelBuilder.Entity<EquipoPartido>().HasData(
                // QF1: Vitality gana 4-1
                new EquipoPartido { Id = 1010, PartidoId = 101, EquipoId = 14, Goles = 4 },
                new EquipoPartido { Id = 1011, PartidoId = 101, EquipoId = 9, Goles = 1 },
                // QF2: Oxygen gana 4-2
                new EquipoPartido { Id = 1020, PartidoId = 102, EquipoId = 6, Goles = 4 },
                new EquipoPartido { Id = 1021, PartidoId = 102, EquipoId = 5, Goles = 2 },
                // QF3: BDS gana 4-3
                new EquipoPartido { Id = 1030, PartidoId = 103, EquipoId = 1, Goles = 4 },
                new EquipoPartido { Id = 1031, PartidoId = 103, EquipoId = 2, Goles = 3 },
                // QF4: KC gana 4-0
                new EquipoPartido { Id = 1040, PartidoId = 104, EquipoId = 3, Goles = 4 },
                new EquipoPartido { Id = 1041, PartidoId = 104, EquipoId = 4, Goles = 0 },
                // SF1: Vitality elimina a Oxygen 4-2
                new EquipoPartido { Id = 1050, PartidoId = 105, EquipoId = 14, Goles = 4 },
                new EquipoPartido { Id = 1051, PartidoId = 105, EquipoId = 6, Goles = 2 },
                // SF2: BDS elimina a KC 4-3
                new EquipoPartido { Id = 1060, PartidoId = 106, EquipoId = 1, Goles = 4 },
                new EquipoPartido { Id = 1061, PartidoId = 106, EquipoId = 3, Goles = 3 },
                // FINAL: Vitality Campeón 4-0
                new EquipoPartido { Id = 1, PartidoId = 1, EquipoId = 14, Goles = 4 },
                new EquipoPartido { Id = 2, PartidoId = 1, EquipoId = 1, Goles = 1 }
            );

            // --- TORNEO 2: RLCS 2024 ---
            modelBuilder.Entity<Partido>().HasData(
                // Cuartos
                new Partido { Id = 201, RondaId = 20, Jugado = true, MVPJugadorId = 5 },  // G2 vs Oxygen
                new Partido { Id = 202, RondaId = 20, Jugado = true, MVPJugadorId = 19 }, // GMA vs Vitality
                new Partido { Id = 203, RondaId = 20, Jugado = true, MVPJugadorId = 10 }, // Falcons vs BDS
                new Partido { Id = 204, RondaId = 20, Jugado = true, MVPJugadorId = 25 }, // NRG vs KC
                                                                                          // Semis
                new Partido { Id = 205, RondaId = 21, Jugado = true, MVPJugadorId = 6 },  // G2 vs GMA
                new Partido { Id = 206, RondaId = 21, Jugado = true, MVPJugadorId = 11 }, // Falcons vs NRG
                                                                                          // Final
                new Partido { Id = 2, RondaId = 2, Jugado = true, MVPJugadorId = 5 }      // G2 vs Falcons
            );

            modelBuilder.Entity<EquipoPartido>().HasData(
                // QF1: G2 gana 4-3 a Oxygen
                new EquipoPartido { Id = 2010, PartidoId = 201, EquipoId = 2, Goles = 4 },
                new EquipoPartido { Id = 2011, PartidoId = 201, EquipoId = 6, Goles = 3 },
                // QF2: GMA gana 4-2
                new EquipoPartido { Id = 2020, PartidoId = 202, EquipoId = 7, Goles = 4 },
                new EquipoPartido { Id = 2021, PartidoId = 202, EquipoId = 14, Goles = 2 },
                // QF3: Falcons gana 4-1
                new EquipoPartido { Id = 2030, PartidoId = 203, EquipoId = 4, Goles = 4 },
                new EquipoPartido { Id = 2031, PartidoId = 203, EquipoId = 1, Goles = 1 },
                // QF4: NRG gana 4-2
                new EquipoPartido { Id = 2040, PartidoId = 204, EquipoId = 9, Goles = 4 },
                new EquipoPartido { Id = 2041, PartidoId = 204, EquipoId = 3, Goles = 2 },
                // SF1: G2 gana 4-0
                new EquipoPartido { Id = 2050, PartidoId = 205, EquipoId = 2, Goles = 4 },
                new EquipoPartido { Id = 2051, PartidoId = 205, EquipoId = 7, Goles = 0 },
                // SF2: Falcons gana 4-2
                new EquipoPartido { Id = 2060, PartidoId = 206, EquipoId = 4, Goles = 4 },
                new EquipoPartido { Id = 2061, PartidoId = 206, EquipoId = 9, Goles = 2 },
                // FINAL: G2 Campeón 4-2
                new EquipoPartido { Id = 3, PartidoId = 2, EquipoId = 2, Goles = 4 },
                new EquipoPartido { Id = 4, PartidoId = 2, EquipoId = 4, Goles = 2 }
            );

            // --- TORNEO 3: RLCS 2025 ---
            modelBuilder.Entity<Partido>().HasData(
                // Cuartos
                new Partido { Id = 301, RondaId = 30, Jugado = true, MVPJugadorId = 7 },  // KC vs NIP
                new Partido { Id = 302, RondaId = 30, Jugado = true, MVPJugadorId = 16 }, // Oxygen vs GenG
                new Partido { Id = 303, RondaId = 30, Jugado = true, MVPJugadorId = 19 }, // GMA vs Furia
                new Partido { Id = 304, RondaId = 30, Jugado = true, MVPJugadorId = 46 }, // Vitality vs G2
                                                                                          // Semis
                new Partido { Id = 305, RondaId = 31, Jugado = true, MVPJugadorId = 7 },  // KC vs Oxygen
                new Partido { Id = 306, RondaId = 31, Jugado = true, MVPJugadorId = 21 }, // GMA vs Vitality
                                                                                          // Final
                new Partido { Id = 3, RondaId = 3, Jugado = true, MVPJugadorId = 7 }      // KC vs GMA
            );

            modelBuilder.Entity<EquipoPartido>().HasData(
                // QF1: KC gana 4-0
                new EquipoPartido { Id = 3010, PartidoId = 301, EquipoId = 3, Goles = 4 },
                new EquipoPartido { Id = 3011, PartidoId = 301, EquipoId = 13, Goles = 0 },
                // QF2: Oxygen gana 4-2
                new EquipoPartido { Id = 3020, PartidoId = 302, EquipoId = 6, Goles = 4 },
                new EquipoPartido { Id = 3021, PartidoId = 302, EquipoId = 16, Goles = 2 },
                // QF3: GMA gana 4-3
                new EquipoPartido { Id = 3030, PartidoId = 303, EquipoId = 7, Goles = 4 },
                new EquipoPartido { Id = 3031, PartidoId = 303, EquipoId = 5, Goles = 3 },
                // QF4: Vitality gana 4-1
                new EquipoPartido { Id = 3040, PartidoId = 304, EquipoId = 14, Goles = 4 },
                new EquipoPartido { Id = 3041, PartidoId = 304, EquipoId = 2, Goles = 1 },
                // SF1: KC gana 4-1 a Oxygen
                new EquipoPartido { Id = 3050, PartidoId = 305, EquipoId = 3, Goles = 4 },
                new EquipoPartido { Id = 3051, PartidoId = 305, EquipoId = 6, Goles = 1 },
                // SF2: GMA gana 4-3
                new EquipoPartido { Id = 3060, PartidoId = 306, EquipoId = 7, Goles = 4 },
                new EquipoPartido { Id = 3061, PartidoId = 306, EquipoId = 14, Goles = 3 },
                // FINAL: KC Campeón 4-3
                new EquipoPartido { Id = 5, PartidoId = 3, EquipoId = 3, Goles = 4 },
                new EquipoPartido { Id = 6, PartidoId = 3, EquipoId = 7, Goles = 3 }
            );

            // ==========================
            // STATS DE JUGADORES (PartidoJugador)
            // ==========================
            modelBuilder.Entity<PartidoJugador>().HasData(

                // T1 Cuartos: 

                // 101: 4-1
                new PartidoJugador { Id = 109, EquipoPartidoId = 1010, JugadorId = 46, Goles = 2, Asistencias = 1, Salvadas = 1, Puntuacion = 700 },
                new PartidoJugador { Id = 110, EquipoPartidoId = 1010, JugadorId = 47, Goles = 1, Asistencias = 1, Salvadas = 2, Puntuacion = 500 },
                new PartidoJugador { Id = 111, EquipoPartidoId = 1010, JugadorId = 48, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 450 },

                new PartidoJugador { Id = 112, EquipoPartidoId = 1011, JugadorId = 25, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 420 },
                new PartidoJugador { Id = 113, EquipoPartidoId = 1011, JugadorId = 26, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 300 },
                new PartidoJugador { Id = 114, EquipoPartidoId = 1011, JugadorId = 27, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 280 },

                // 102:
                new PartidoJugador { Id = 100, EquipoPartidoId = 1020, JugadorId = 16, Goles = 3, Asistencias = 1, Salvadas = 4, Puntuacion = 850 }, // MVP del partido
                new PartidoJugador { Id = 101, EquipoPartidoId = 1020, JugadorId = 17, Goles = 1, Asistencias = 2, Salvadas = 1, Puntuacion = 400 },
                new PartidoJugador { Id = 102, EquipoPartidoId = 1020, JugadorId = 18, Goles = 0, Asistencias = 1, Salvadas = 3, Puntuacion = 320 },

                new PartidoJugador { Id = 127, EquipoPartidoId = 1021, JugadorId = 13, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 420 },
                new PartidoJugador { Id = 128, EquipoPartidoId = 1021, JugadorId = 14, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 400 },
                new PartidoJugador { Id = 129, EquipoPartidoId = 1021, JugadorId = 15, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 300 },

                // 103:
                new PartidoJugador { Id = 115, EquipoPartidoId = 1030, JugadorId = 1, Goles = 2, Asistencias = 0, Salvadas = 2, Puntuacion = 680 },
                new PartidoJugador { Id = 116, EquipoPartidoId = 1030, JugadorId = 2, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 520 },
                new PartidoJugador { Id = 117, EquipoPartidoId = 1030, JugadorId = 3, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 510 },

                new PartidoJugador { Id = 118, EquipoPartidoId = 1031, JugadorId = 4, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 480 },
                new PartidoJugador { Id = 119, EquipoPartidoId = 1031, JugadorId = 5, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 500 },
                new PartidoJugador { Id = 120, EquipoPartidoId = 1031, JugadorId = 6, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 460 },

                // 104:
                new PartidoJugador { Id = 121, EquipoPartidoId = 1040, JugadorId = 7, Goles = 2, Asistencias = 1, Salvadas = 1, Puntuacion = 720 },
                new PartidoJugador { Id = 122, EquipoPartidoId = 1040, JugadorId = 8, Goles = 1, Asistencias = 1, Salvadas = 2, Puntuacion = 600 },
                new PartidoJugador { Id = 123, EquipoPartidoId = 1040, JugadorId = 9, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 540 },

                new PartidoJugador { Id = 124, EquipoPartidoId = 1041, JugadorId = 10, Goles = 0, Asistencias = 0, Salvadas = 3, Puntuacion = 350 },
                new PartidoJugador { Id = 125, EquipoPartidoId = 1041, JugadorId = 11, Goles = 0, Asistencias = 0, Salvadas = 2, Puntuacion = 300 },
                new PartidoJugador { Id = 126, EquipoPartidoId = 1041, JugadorId = 12, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 260 },

                // T1 Semis:

                // 105:
                new PartidoJugador { Id = 130, EquipoPartidoId = 1050, JugadorId = 46, Goles = 2, Asistencias = 1, Salvadas = 1, Puntuacion = 720 },
                new PartidoJugador { Id = 131, EquipoPartidoId = 1050, JugadorId = 47, Goles = 1, Asistencias = 1, Salvadas = 2, Puntuacion = 520 },
                new PartidoJugador { Id = 132, EquipoPartidoId = 1050, JugadorId = 48, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 480 },

                new PartidoJugador { Id = 133, EquipoPartidoId = 1051, JugadorId = 17, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 360 },
                new PartidoJugador { Id = 134, EquipoPartidoId = 1051, JugadorId = 18, Goles = 0, Asistencias = 1, Salvadas = 1, Puntuacion = 300 },
                new PartidoJugador { Id = 103, EquipoPartidoId = 1051, JugadorId = 16, Goles = 1, Asistencias = 0, Salvadas = 6, Puntuacion = 680 },

                // 106:
                new PartidoJugador { Id = 135, EquipoPartidoId = 1060, JugadorId = 1, Goles = 2, Asistencias = 0, Salvadas = 2, Puntuacion = 680 },
                new PartidoJugador { Id = 136, EquipoPartidoId = 1060, JugadorId = 2, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 520 },
                new PartidoJugador { Id = 137, EquipoPartidoId = 1060, JugadorId = 3, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 500 },

                new PartidoJugador { Id = 138, EquipoPartidoId = 1061, JugadorId = 7, Goles = 1, Asistencias = 1, Salvadas = 2, Puntuacion = 560 },
                new PartidoJugador { Id = 139, EquipoPartidoId = 1061, JugadorId = 8, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 480 },
                new PartidoJugador { Id = 140, EquipoPartidoId = 1061, JugadorId = 9, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 460 },

                // Finales a parte

                // T2 Cuartos:

                // 201:
                new PartidoJugador { Id = 104, EquipoPartidoId = 2011, JugadorId = 16, Goles = 2, Asistencias = 1, Salvadas = 3, Puntuacion = 710 },
                new PartidoJugador { Id = 105, EquipoPartidoId = 2011, JugadorId = 17, Goles = 0, Asistencias = 1, Salvadas = 1, Puntuacion = 250 },
                new PartidoJugador { Id = 999, EquipoPartidoId = 2011, JugadorId = 18, Goles = 1, Asistencias = 1, Salvadas = 0, Puntuacion = 250 },

                new PartidoJugador { Id = 141, EquipoPartidoId = 2010, JugadorId = 4, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 520 },
                new PartidoJugador { Id = 142, EquipoPartidoId = 2010, JugadorId = 6, Goles = 0, Asistencias = 1, Salvadas = 2, Puntuacion = 400 },
                new PartidoJugador { Id = 106, EquipoPartidoId = 2010, JugadorId = 5, Goles = 3, Asistencias = 1, Salvadas = 2, Puntuacion = 800 }, // BeastMode

                // 202:
                new PartidoJugador { Id = 143, EquipoPartidoId = 2020, JugadorId = 19, Goles = 2, Asistencias = 0, Salvadas = 2, Puntuacion = 650 },
                new PartidoJugador { Id = 144, EquipoPartidoId = 2020, JugadorId = 20, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 500 },
                new PartidoJugador { Id = 145, EquipoPartidoId = 2020, JugadorId = 21, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 480 },

                new PartidoJugador { Id = 146, EquipoPartidoId = 2021, JugadorId = 46, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 480 },
                new PartidoJugador { Id = 147, EquipoPartidoId = 2021, JugadorId = 47, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 420 },
                new PartidoJugador { Id = 148, EquipoPartidoId = 2021, JugadorId = 48, Goles = 0, Asistencias = 1, Salvadas = 1, Puntuacion = 360 },

                // 203.
                new PartidoJugador { Id = 149, EquipoPartidoId = 2030, JugadorId = 10, Goles = 2, Asistencias = 0, Salvadas = 2, Puntuacion = 620 },
                new PartidoJugador { Id = 150, EquipoPartidoId = 2030, JugadorId = 11, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 500 },
                new PartidoJugador { Id = 151, EquipoPartidoId = 2030, JugadorId = 12, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 480 },

                new PartidoJugador { Id = 152, EquipoPartidoId = 2031, JugadorId = 1, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 420 },
                new PartidoJugador { Id = 153, EquipoPartidoId = 2031, JugadorId = 2, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 300 },
                new PartidoJugador { Id = 154, EquipoPartidoId = 2031, JugadorId = 3, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 280 },

                // 204:
                new PartidoJugador { Id = 155, EquipoPartidoId = 2040, JugadorId = 25, Goles = 2, Asistencias = 0, Salvadas = 2, Puntuacion = 620 },
                new PartidoJugador { Id = 156, EquipoPartidoId = 2040, JugadorId = 26, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 500 },
                new PartidoJugador { Id = 157, EquipoPartidoId = 2040, JugadorId = 27, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 480 },

                new PartidoJugador { Id = 158, EquipoPartidoId = 2041, JugadorId = 7, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 460 },
                new PartidoJugador { Id = 159, EquipoPartidoId = 2041, JugadorId = 8, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 420 },
                new PartidoJugador { Id = 160, EquipoPartidoId = 2041, JugadorId = 9, Goles = 0, Asistencias = 1, Salvadas = 1, Puntuacion = 380 },

                // T2 Semis:

                // 205:
                new PartidoJugador { Id = 161, EquipoPartidoId = 2050, JugadorId = 4, Goles = 1, Asistencias = 1, Salvadas = 2, Puntuacion = 520 },
                new PartidoJugador { Id = 162, EquipoPartidoId = 2050, JugadorId = 5, Goles = 2, Asistencias = 0, Salvadas = 1, Puntuacion = 700 },
                new PartidoJugador { Id = 163, EquipoPartidoId = 2050, JugadorId = 6, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 500 },

                new PartidoJugador { Id = 164, EquipoPartidoId = 2051, JugadorId = 19, Goles = 0, Asistencias = 0, Salvadas = 2, Puntuacion = 320 },
                new PartidoJugador { Id = 165, EquipoPartidoId = 2051, JugadorId = 20, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 280 },
                new PartidoJugador { Id = 166, EquipoPartidoId = 2051, JugadorId = 21, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 260 },

                // 206:
                new PartidoJugador { Id = 167, EquipoPartidoId = 2060, JugadorId = 10, Goles = 2, Asistencias = 0, Salvadas = 2, Puntuacion = 620 },
                new PartidoJugador { Id = 168, EquipoPartidoId = 2060, JugadorId = 11, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 500 },
                new PartidoJugador { Id = 169, EquipoPartidoId = 2060, JugadorId = 12, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 480 },

                new PartidoJugador { Id = 170, EquipoPartidoId = 2061, JugadorId = 25, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 450 },
                new PartidoJugador { Id = 171, EquipoPartidoId = 2061, JugadorId = 26, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 420 },
                new PartidoJugador { Id = 172, EquipoPartidoId = 2061, JugadorId = 27, Goles = 0, Asistencias = 1, Salvadas = 1, Puntuacion = 380 },

                // Finales a parte



                // T3 Cuartos:

                // 301:
                new PartidoJugador { Id = 173, EquipoPartidoId = 3010, JugadorId = 7, Goles = 2, Asistencias = 1, Salvadas = 2, Puntuacion = 720 },
                new PartidoJugador { Id = 174, EquipoPartidoId = 3010, JugadorId = 8, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 560 },
                new PartidoJugador { Id = 175, EquipoPartidoId = 3010, JugadorId = 9, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 520 },

                new PartidoJugador { Id = 176, EquipoPartidoId = 3011, JugadorId = 37, Goles = 0, Asistencias = 0, Salvadas = 2, Puntuacion = 300 },
                new PartidoJugador { Id = 177, EquipoPartidoId = 3011, JugadorId = 38, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 260 },
                new PartidoJugador { Id = 178, EquipoPartidoId = 3011, JugadorId = 39, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 240 },

                // 302:
                new PartidoJugador { Id = 179, EquipoPartidoId = 3020, JugadorId = 17, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 480 },
                new PartidoJugador { Id = 180, EquipoPartidoId = 3020, JugadorId = 18, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 420 },
                new PartidoJugador { Id = 107, EquipoPartidoId = 3020, JugadorId = 16, Goles = 2, Asistencias = 2, Salvadas = 2, Puntuacion = 750 },

                new PartidoJugador { Id = 181, EquipoPartidoId = 3021, JugadorId = 43, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 460 },
                new PartidoJugador { Id = 182, EquipoPartidoId = 3021, JugadorId = 44, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 420 },
                new PartidoJugador { Id = 183, EquipoPartidoId = 3021, JugadorId = 45, Goles = 0, Asistencias = 1, Salvadas = 1, Puntuacion = 380 },

                // 303:
                new PartidoJugador { Id = 184, EquipoPartidoId = 3030, JugadorId = 19, Goles = 2, Asistencias = 0, Salvadas = 2, Puntuacion = 640 },
                new PartidoJugador { Id = 185, EquipoPartidoId = 3030, JugadorId = 20, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 520 },
                new PartidoJugador { Id = 186, EquipoPartidoId = 3030, JugadorId = 21, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 500 },

                new PartidoJugador { Id = 187, EquipoPartidoId = 3031, JugadorId = 13, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 460 },
                new PartidoJugador { Id = 188, EquipoPartidoId = 3031, JugadorId = 14, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 480 },
                new PartidoJugador { Id = 189, EquipoPartidoId = 3031, JugadorId = 15, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 440 },

                // 304:
                new PartidoJugador { Id = 190, EquipoPartidoId = 3040, JugadorId = 46, Goles = 2, Asistencias = 1, Salvadas = 1, Puntuacion = 700 },
                new PartidoJugador { Id = 191, EquipoPartidoId = 3040, JugadorId = 47, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 520 },
                new PartidoJugador { Id = 192, EquipoPartidoId = 3040, JugadorId = 48, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 540 },

                new PartidoJugador { Id = 193, EquipoPartidoId = 3041, JugadorId = 4, Goles = 1, Asistencias = 0, Salvadas = 2, Puntuacion = 420 },
                new PartidoJugador { Id = 194, EquipoPartidoId = 3041, JugadorId = 5, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 300 },
                new PartidoJugador { Id = 195, EquipoPartidoId = 3041, JugadorId = 6, Goles = 0, Asistencias = 0, Salvadas = 1, Puntuacion = 280 },


                // T3 Semis:

                // 305:
                new PartidoJugador { Id = 196, EquipoPartidoId = 3050, JugadorId = 7, Goles = 2, Asistencias = 1, Salvadas = 2, Puntuacion = 720 },
                new PartidoJugador { Id = 197, EquipoPartidoId = 3050, JugadorId = 8, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 560 },
                new PartidoJugador { Id = 198, EquipoPartidoId = 3050, JugadorId = 9, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 520 },

                new PartidoJugador { Id = 199, EquipoPartidoId = 3051, JugadorId = 17, Goles = 0, Asistencias = 0, Salvadas = 2, Puntuacion = 320 },
                new PartidoJugador { Id = 200, EquipoPartidoId = 3051, JugadorId = 18, Goles = 0, Asistencias = 1, Salvadas = 1, Puntuacion = 300 },
                new PartidoJugador { Id = 108, EquipoPartidoId = 3051, JugadorId = 16, Goles = 1, Asistencias = 0, Salvadas = 5, Puntuacion = 550 },

                // 306:
                new PartidoJugador { Id = 201, EquipoPartidoId = 3060, JugadorId = 19, Goles = 2, Asistencias = 0, Salvadas = 2, Puntuacion = 640 },
                new PartidoJugador { Id = 202, EquipoPartidoId = 3060, JugadorId = 20, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 520 },
                new PartidoJugador { Id = 203, EquipoPartidoId = 3060, JugadorId = 21, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 500 },

                new PartidoJugador { Id = 204, EquipoPartidoId = 3061, JugadorId = 46, Goles = 1, Asistencias = 1, Salvadas = 2, Puntuacion = 560 },
                new PartidoJugador { Id = 205, EquipoPartidoId = 3061, JugadorId = 47, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 480 },
                new PartidoJugador { Id = 206, EquipoPartidoId = 3061, JugadorId = 48, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 460 },

                // --------
                // FINALES
                // --------

                // FINAL 2023: Vitality (4) vs BDS (0) -> Partido Dominante
                new PartidoJugador { Id = 1, EquipoPartidoId = 1, JugadorId = 46, Goles = 2, Asistencias = 1, Salvadas = 1, Puntuacion = 650 }, // Alpha54
                new PartidoJugador { Id = 2, EquipoPartidoId = 1, JugadorId = 47, Goles = 1, Asistencias = 1, Salvadas = 2, Puntuacion = 450 }, // Radosin
                new PartidoJugador { Id = 3, EquipoPartidoId = 1, JugadorId = 48, Goles = 1, Asistencias = 2, Salvadas = 1, Puntuacion = 500 }, // Fairy
                                                                                                                                                // BDS
                new PartidoJugador { Id = 4, EquipoPartidoId = 2, JugadorId = 1, Goles = 0, Asistencias = 0, Salvadas = 4, Puntuacion = 380 }, // Monkey Moon
                new PartidoJugador { Id = 5, EquipoPartidoId = 2, JugadorId = 2, Goles = 0, Asistencias = 0, Salvadas = 2, Puntuacion = 220 },
                new PartidoJugador { Id = 6, EquipoPartidoId = 2, JugadorId = 3, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 340 },

                // FINAL 2024: G2 (4) vs Falcons (1) -> Partido con Goles
                new PartidoJugador { Id = 7, EquipoPartidoId = 3, JugadorId = 4, Goles = 1, Asistencias = 2, Salvadas = 2, Puntuacion = 580 }, // Atomic
                new PartidoJugador { Id = 8, EquipoPartidoId = 3, JugadorId = 5, Goles = 3, Asistencias = 0, Salvadas = 1, Puntuacion = 820 }, // BeastMode Hat-trick
                new PartidoJugador { Id = 9, EquipoPartidoId = 3, JugadorId = 6, Goles = 0, Asistencias = 3, Salvadas = 1, Puntuacion = 500 }, // Daniel
                                                                                                                                               // Falcons
                new PartidoJugador { Id = 10, EquipoPartidoId = 4, JugadorId = 10, Goles = 1, Asistencias = 0, Salvadas = 3, Puntuacion = 450 }, // Trk
                new PartidoJugador { Id = 11, EquipoPartidoId = 4, JugadorId = 11, Goles = 0, Asistencias = 1, Salvadas = 2, Puntuacion = 300 },
                new PartidoJugador { Id = 12, EquipoPartidoId = 4, JugadorId = 12, Goles = 1, Asistencias = 0, Salvadas = 1, Puntuacion = 350 },

                // FINAL 2025: KC (4) vs GMA (3) -> Partido Tenso (Game 7 Overtime stats)
                new PartidoJugador { Id = 13, EquipoPartidoId = 5, JugadorId = 7, Goles = 2, Asistencias = 1, Salvadas = 4, Puntuacion = 900 }, // Vatira Clutch
                new PartidoJugador { Id = 14, EquipoPartidoId = 5, JugadorId = 8, Goles = 1, Asistencias = 2, Salvadas = 2, Puntuacion = 600 },
                new PartidoJugador { Id = 15, EquipoPartidoId = 5, JugadorId = 9, Goles = 1, Asistencias = 1, Salvadas = 1, Puntuacion = 550 },
                // Gentle Mates
                new PartidoJugador { Id = 16, EquipoPartidoId = 6, JugadorId = 19, Goles = 2, Asistencias = 0, Salvadas = 1, Puntuacion = 620 }, // Juicy
                new PartidoJugador { Id = 17, EquipoPartidoId = 6, JugadorId = 20, Goles = 0, Asistencias = 2, Salvadas = 3, Puntuacion = 480 },
                new PartidoJugador { Id = 18, EquipoPartidoId = 6, JugadorId = 21, Goles = 1, Asistencias = 1, Salvadas = 2, Puntuacion = 510 }
            );

            // ==========================
            // INSCRIPCIONES (EquipoTorneo)
            // ==========================
            modelBuilder.Entity<EquipoTorneo>().HasData(
                // T1 2023
                new EquipoTorneo { Id = 1, TorneoId = 1, EquipoId = 14, PosicionFinal = 1, Estado = EstadoParticipacion.Campeon },
                new EquipoTorneo { Id = 2, TorneoId = 1, EquipoId = 1, PosicionFinal = 2, Estado = EstadoParticipacion.Eliminado },
                new EquipoTorneo { Id = 100, TorneoId = 1, EquipoId = 6, PosicionFinal = 3, Estado = EstadoParticipacion.Eliminado }, // Oxygen Semis
                new EquipoTorneo { Id = 101, TorneoId = 1, EquipoId = 3, PosicionFinal = 3, Estado = EstadoParticipacion.Eliminado }, // KC Semis

                // T2 2024
                new EquipoTorneo { Id = 3, TorneoId = 2, EquipoId = 2, PosicionFinal = 1, Estado = EstadoParticipacion.Campeon },
                new EquipoTorneo { Id = 4, TorneoId = 2, EquipoId = 4, PosicionFinal = 2, Estado = EstadoParticipacion.Eliminado },
                new EquipoTorneo { Id = 200, TorneoId = 2, EquipoId = 6, PosicionFinal = 5, Estado = EstadoParticipacion.Eliminado }, // Oxygen QF

                // T3 2025
                new EquipoTorneo { Id = 5, TorneoId = 3, EquipoId = 3, PosicionFinal = 1, Estado = EstadoParticipacion.Campeon },
                new EquipoTorneo { Id = 6, TorneoId = 3, EquipoId = 7, PosicionFinal = 2, Estado = EstadoParticipacion.Eliminado },
                new EquipoTorneo { Id = 300, TorneoId = 3, EquipoId = 6, PosicionFinal = 3, Estado = EstadoParticipacion.Eliminado } // Oxygen Semis
            );


        }
    }
}
