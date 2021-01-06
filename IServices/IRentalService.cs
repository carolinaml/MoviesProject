using MoviesProject.DTO;
using MoviesProject.Models;
using System.Collections.Generic;

namespace MoviesProject.IServices
{
    public interface IRentalService
    {
        IEnumerable<Rental> GetRentals();
        Rental GetRentalById(int id);
        Rental AddRental(RentalDTO rental);
        Rental UpdateRental(RentalDTO rental);
        Rental DeleteRental(int id);
    }
}