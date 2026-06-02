# RL-TournamentManager

RL-TournamentManager es una aplicación web diseñada para la gestión completa de torneos de Rocket League (u otros deportes electrónicos/tradicionales). Permite administrar de manera sencilla equipos, jugadores, torneos, rondas y partidos, así como hacer un seguimiento de los resultados y visualizar rankings.

## Tecnologías

- **Framework:** ASP.NET Core 8.0 (MVC)
- **Lenguaje:** C#
- **Base de Datos:** SQL Server con Entity Framework Core
- **Seguridad/Autenticación:** ASP.NET Core Identity
- **Frontend:** Razor Views, HTML, CSS, JavaScript

## Características

- **Gestión de Torneos:** Creación de torneos utilizando un asistente guiado (Wizard).
- **Gestión de Equipos y Jugadores:** Administración de la plantilla de jugadores y la formación de los equipos.
- **Encuentros y Rondas:** Organización estructurada de las competiciones en rondas y registro de los resultados de cada partido.
- **Rankings:** Visualización de la clasificación y desempeño de los participantes.
- **Control de Acceso:** Sistema de registro e inicio de sesión de usuarios.

## Capturas
[imagen o gif]

## Instalación

1. Clona el repositorio en tu máquina local.
2. Asegúrate de tener instalado el [SDK de .NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) y tener acceso a una instancia de SQL Server.
3. Abre una consola en el directorio raíz del proyecto.
4. Restaura las dependencias de NuGet ejecutando:
   ```bash
   dotnet restore
   ```
5. Aplica las migraciones para inicializar la base de datos:
   ```bash
   dotnet ef database update --project TournamentManager
   ```

## Uso

1. Ejecuta el proyecto desde la línea de comandos:
   ```bash
   dotnet run --project TournamentManager
   ```
2. Abre tu navegador y accede a la URL que indica la consola (habitualmente `https://localhost:7XXX` o `http://localhost:5XXX`).
3. Navega por las diferentes secciones del menú superior para crear jugadores, formar equipos y usar el "Tournament Wizard" para inicializar tu primer torneo.

## Arquitectura

El proyecto sigue el patrón de diseño arquitectónico **MVC (Model-View-Controller)** clásico de ASP.NET Core, organizado de la siguiente manera:

- **Models:** Contiene las clases de dominio o entidades (`Torneo`, `Equipo`, `Jugador`, `Partido`, `Ronda`, etc.) que representan la estructura de los datos y se mapean a las tablas de SQL Server mediante EF Core.
- **Views:** Archivos `.cshtml` (Razor) responsables de presentar la interfaz de usuario al navegador.
- **Controllers:** Clases como `TorneoController`, `EquipoController` o `RankingsController` que reciben las peticiones web, procesan la lógica de negocio apoyándose en los modelos y devuelven la vista adecuada.
- **Data/Migrations:** Carpeta dedicada a la configuración del contexto de la base de datos (Entity Framework) y los scripts de migración para el control de versiones del esquema de base de datos.
