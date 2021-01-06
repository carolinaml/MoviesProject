using System;
using System.Collections.Generic;

namespace MoviesProject.Models
{
    public partial class Rental
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public DateTime Date { get; set; }
        public IList<Film> Films { get; set; }
    }
}