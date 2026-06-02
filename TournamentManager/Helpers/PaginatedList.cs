using Microsoft.EntityFrameworkCore;

namespace TournamentManager.Helpers // O tu namespace preferido
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        // Propiedades para saber si hay botón "Anterior" o "Siguiente"
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

        // En Helpers/PaginatedList.cs
        public static PaginatedList<T> Create(List<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count;
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

        // Método estático para crear la página de forma asíncrona
        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync(); // Cuenta total en BBDD
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync(); // Carga solo los necesarios

            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}