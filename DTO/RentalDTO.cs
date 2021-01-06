using System;
using System.Collections.Generic;

namespace MoviesProject.DTO
{
    public partial class RentalDTO
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public DateTime Date { get; set; }
        public IList<int> FilmsIds { get; set; }
    }
}