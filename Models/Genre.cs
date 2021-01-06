using System;

namespace MoviesProject.Models
{
    public partial class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
    }
}
