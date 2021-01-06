using System;

namespace MoviesProject.DTO
{
    public partial class GenreDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
    }
}
