using Microsoft.AspNetCore.Mvc;
using MoviesProject.DTO;
using MoviesProject.IServices;
using MoviesProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesProject.Controllers
{
    //This Controller can be refactorized using asynchronous operations /Tasks/
    // with more operations that ensures secured calls and secured execution of tasks
    // and finally, with a detailed response
    // For timing issues, is this a simple/basic controller
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _rentalService;
        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Rental/GetRental")]
        public IEnumerable<Rental> GetRental()
        {
            return _rentalService.GetRentals();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Rental/AddRental")]
        public Rental AddRental(RentalDTO Rental)
        {
            return _rentalService.AddRental(Rental);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Rental/EditRental")]
        public Rental EditRental(RentalDTO Rental)
        {
            return _rentalService.UpdateRental(Rental);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Rental/DeleteRental")]
        public Rental DeleteRental(int id)
        {
            return _rentalService.DeleteRental(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Rental/GetRentalId")]
        public Rental GetRentalId(int id)
        {
            return _rentalService.GetRentalById(id);
        }
    }
}
