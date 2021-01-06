using Microsoft.EntityFrameworkCore;
using MoviesProject.DTO;
using MoviesProject.IServices;
using MoviesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProject.Services
{
    public class FilmService : IFilmService
    {
        MoviesAPIContext _context;
        IGenreService _genreService;

        public FilmService(MoviesAPIContext _db, IGenreService genreService)
        {
            _context = _db;
            _genreService = genreService;
        }

        public IEnumerable<Film> GetFilms()
        {
            var films = _context.Films.ToList();
            return films;
        }

        public Film GetFilmById(int id)
        {
            var film = _context.Films.FirstOrDefault(x => x.Id == id);
            return film;
        }

        public Film AddFilm(FilmDTO filmDto)
        {
            if (filmDto != null)
            {
                Film film = new Film
                {
                    Id = filmDto.Id,
                    Name = filmDto.Name,
                    CreationDate = filmDto.CreationDate,
                    Active = filmDto.Active,
                    Genre = _genreService.GetGenreById(filmDto.GenreId)
                };

                _context.Films.Add(film);
                _context.SaveChanges();
                return film;
            }
            return null;
        }

        public Film UpdateFilm(FilmDTO filmDto)
        {
            Film film = GetFilmById(filmDto.Id);

            film.Name = filmDto.Name;
            film.CreationDate = filmDto.CreationDate;
            film.Active = filmDto.Active;
            film.Genre = _genreService.GetGenreById(filmDto.GenreId);

            _context.Entry(film).State = EntityState.Modified;
            _context.SaveChanges();
            return film;
        }

        public Film DeleteFilm(int id)
        {
            var film = _context.Films.FirstOrDefault(x => x.Id == id);
            _context.Entry(film).State = EntityState.Deleted;
            _context.SaveChanges();
            return film;
        }
    }
}
