using MoviesProject.DTO;
using MoviesProject.Models;
using System.Collections.Generic;

namespace MoviesProject.IServices
{
    public interface IGenreService
    {
        IEnumerable<Genre> GetGenres();
        Genre GetGenreById(int id);
        Genre AddGenre(GenreDTO genre);
        Genre UpdateGenre(GenreDTO genre);
        Genre DeleteGenre(int id);
    }
}