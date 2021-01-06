using Microsoft.AspNetCore.Mvc;
using MoviesProject.DTO;
using MoviesProject.IServices;
using MoviesProject.Models;
using System.Collections.Generic;

namespace MoviesProject.Controllers
{
    //This Controller can be refactorized using asynchronous operations /Tasks/
    // with more operations that ensures secured calls and secured execution of tasks
    // and finally, with a detailed response
    // For timing issues, is this a simple/basic controller
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Genre/GetGenre")]
        public IEnumerable<Genre> GetGenre()
        {
            return _genreService.GetGenres();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Genre/AddGenre")]
        public Genre AddGenre(GenreDTO Genre)
        {
            return _genreService.AddGenre(Genre);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Genre/EditGenre")]
        public Genre EditGenre(GenreDTO Genre)
        {
            return _genreService.UpdateGenre(Genre);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Genre/DeleteGenre")]
        public Genre DeleteGenre(int id)
        {
            return _genreService.DeleteGenre(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Genre/GetGenreId")]
        public Genre GetGenreId(int id)
        {
            return _genreService.GetGenreById(id);
        }
    }
}
