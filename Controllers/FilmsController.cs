using Microsoft.AspNetCore.Mvc;
using MoviesProject.DTO;
using MoviesProject.IServices;
using MoviesProject.Models;
using System;
using System.Collections.Generic;

namespace MoviesProject.Controllers
{
    //This Controller can be refactorized using asynchronous operations /Tasks/
    // with more operations that ensures secured calls and secured execution of tasks
    // and finally, with a detailed response
    // For timing issues, is this a simple/basic controller
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmService _filmService;
        public FilmsController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Film/GetFilm")]
        public IEnumerable<Film> GetFilm()
        {
            return _filmService.GetFilms();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Film/AddFilm")]
        public Film AddFilm(FilmDTO Film)
        {
            return _filmService.AddFilm(Film);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Film/EditFilm")]
        public Film EditFilm(FilmDTO Film)
        {
            return _filmService.UpdateFilm(Film);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Film/DeleteFilm")]
        public Film DeleteFilm(int id)
        {
            return _filmService.DeleteFilm(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Film/GetFilmId")]
        public Film GetFilmId(int id)
        {
            return _filmService.GetFilmById(id);
        }
    }
}
