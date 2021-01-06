using System;

namespace MoviesProject.DTO
{
    public partial class FilmDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
        public int GenreId { get; set; }
    }
}
