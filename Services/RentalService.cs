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
    public class RentalService : IRentalService
    {
        MoviesAPIContext _context;
        IFilmService _filmService;

        public RentalService(MoviesAPIContext _db, IFilmService filmService)
        {
            _context = _db;
            _filmService = filmService;
        }

        public IEnumerable<Rental> GetRentals()
        {
            var rentals = _context.Rentals.ToList();
            return rentals;
        }

        public Rental GetRentalById(int id)
        {
            var rental = _context.Rentals.FirstOrDefault(x => x.Id == id);
            return rental;
        }

        public Rental AddRental(RentalDTO rentalDto)
        {
            if (rentalDto != null)
            {
                IList<Film> filmList = new List<Film>();

                foreach (var filmId in rentalDto.FilmsIds)
                {
                    filmList.Add(_filmService.GetFilmById(filmId));
                }

                Rental rental = new Rental
                {
                    Id = rentalDto.Id,
                    Cpf = rentalDto.Cpf,
                    Date = rentalDto.Date,
                    Films = filmList
                };

                _context.Rentals.Add(rental);
                _context.SaveChanges();
                return rental;
            }
            return null;
        }

        public Rental UpdateRental(RentalDTO rentalDto)
        {
            Rental rental = GetRentalById(rentalDto.Id);

            IList<Film> filmList = new List<Film>();

            foreach (var filmId in rentalDto.FilmsIds)
            {
                filmList.Add(_filmService.GetFilmById(filmId));
            }

            rental.Id = rentalDto.Id;
            rental.Cpf = rentalDto.Cpf;
            rental.Date = rentalDto.Date;
            rental.Films = filmList;

            _context.Entry(rental).State = EntityState.Modified;
            _context.SaveChanges();
            return rental;
        }

        public Rental DeleteRental(int id)
        {
            var rental = _context.Rentals.FirstOrDefault(x => x.Id == id);
            _context.Entry(rental).State = EntityState.Deleted;
            _context.SaveChanges();
            return rental;
        }
    }
}
