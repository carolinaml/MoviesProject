using MoviesProject.DTO;
using MoviesProject.Models;
using System.Collections.Generic;

namespace MoviesProject.IServices
{
    public interface IFilmService
    {
        IEnumerable<Film> GetFilms();
        Film GetFilmById(int id);
        Film AddFilm(FilmDTO film);
        Film UpdateFilm(FilmDTO film);
        Film DeleteFilm(int id);
    }
}