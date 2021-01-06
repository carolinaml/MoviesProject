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
    public class GenreService : IGenreService
    {
        MoviesAPIContext _context;

        public GenreService(MoviesAPIContext _db)
        {
            _context = _db;
        }

        public IEnumerable<Genre> GetGenres()
        {
            var genres = _context.Genres.ToList();
            return genres;
        }

        public Genre GetGenreById(int id)
        {
            var genre = _context.Genres.FirstOrDefault(x => x.Id == id);
            return genre;
        }

        public Genre AddGenre(GenreDTO genreDto)
        {
            if (genreDto != null)
            {
                Genre genre = new Genre
                {
                    Id = genreDto.Id,
                    Name = genreDto.Name,
                    CreationDate = genreDto.CreationDate,
                    Active = genreDto.Active
                };

                _context.Genres.Add(genre);
                _context.SaveChanges();
                return genre;
            }
            return null;
        }

        public Genre UpdateGenre(GenreDTO genreDto)
        {
            Genre genre = GetGenreById(genreDto.Id);

            genre.Name = genreDto.Name;
            genre.Active = genreDto.Active;
            genre.CreationDate = genreDto.CreationDate;

            _context.Entry(genre).State = EntityState.Modified;
            _context.SaveChanges();
            return genre;
        }

        public Genre DeleteGenre(int id)
        {
            var genre = _context.Genres.FirstOrDefault(x => x.Id == id);
            _context.Entry(genre).State = EntityState.Deleted;
            _context.SaveChanges();
            return genre;
        }
    }
}
