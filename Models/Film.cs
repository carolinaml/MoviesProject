using System;

namespace MoviesProject.Models
{
    public partial class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
        public Genre Genre { get; set; }
    }
}
