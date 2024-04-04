using BMSClone.DTOs;
using BMSClone.Models;
using BMSClone.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BMSClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IDataservice _dataService;
        public MovieController(IDataservice dataService)
        { 
        
            _dataService = dataService;
        
        
        }
        [HttpGet]
        public async Task<List<Movie>> GetAllMovies()
        {
            return await _dataService.GetMovies();
            
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> createMovie(MovieDTO moviedto)
        {
            try
            {
                if (moviedto == null)
                {
                    return BadRequest();
                
                }

                Movie movie1 = new Movie();
                movie1.Rating = moviedto.Rating;
                movie1.Name = moviedto.Name;
                movie1.Genre = moviedto.Genre;

                var movie = await _dataService.CreateMovie(movie1);
                return Ok(movie);

            }
            catch(Exception ) { 

                return StatusCode(500);

            }
        
        }


        [HttpGet]
        [Route("GetCities")]
        public async Task<ActionResult<List<City>>> GetCities()
        {

            List<City> city = new List<City>();
            try
            {
                city= await _dataService.GetCities();

                return Ok(city);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("AddCity")]
        public async Task<ActionResult<City>> AddCity(NameDTO city)
        { 
            City city1 = new City();

            city1.Name = city.Name;

            var citye = await _dataService.AddCity(city1);
            return Ok(citye);
        
        
        }


        [HttpGet]
        [Route("GetTheatres")]
        public async Task<ActionResult<List<City>>> GetTheatres()
        {

            List<Theatre> theatres = new List<Theatre>();
            try
            {
                theatres = await _dataService.GetTheatres();

                return Ok(theatres);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("AddTheatres")]
        public async Task<ActionResult<City>> AddTheatres(TheatreDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    return BadRequest();

                }

                Theatre theatre = new Theatre();

                theatre.Name = dto.Name;
                theatre.address = dto.address;
                theatre.cityId = dto.cityId;

                var movie = await _dataService.AddTheatre(theatre);
                return Ok(movie);

            }
            catch (Exception)
            {

                return StatusCode(500);

            }


        }

        [HttpGet]
        [Route("GetLanguages")]
        public async Task<ActionResult<List<City>>> GetLanguages()
        {

            List<Language> city = new List<Language>();
            try
            {
                city = await _dataService.GetLanguages();

                return Ok(city);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("AddLanguage")]
        public async Task<ActionResult<City>> AddLanguage(NameDTO city)
        {
            Language city1 = new Language();

            city1.Name = city.Name;

            var citye = await _dataService.AddLanguage(city1);
            return Ok(citye);
        }



        [HttpGet]
        [Route("GetHalls")]
        public async Task<ActionResult<List<Hall>>> GetHalls(int theatreid)
        {

            List<Hall> halls = new List<Hall>();
            try
            {
                halls = await _dataService.GetHalls(theatreid);

                return Ok(halls);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("AddHalls")]
        public async Task<ActionResult<City>> AddHalls(HallDTO hall)
        {
            Hall hall1 = new Hall();
            hall1.Name = hall.hallName;
            hall1.TheatreId = hall.theatreId;
            var citye = await _dataService.AddHalls(hall1);
            return Ok(citye);
        }



        [HttpGet]
        [Route("GetSeats")]
        public async Task<ActionResult<List<Seat>>> GetSeats(int hallid)
        {

            List<Seat> halls = new List<Seat>();
            try
            {
                halls = await _dataService.GetSeats(hallid);

                return Ok(halls);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("AddSeats")]
        public async Task<ActionResult<City>> AddSeats(SeatDTO seatDTO)
        {
           
            Seat seat = new Seat();

            seat.seatNumber = seatDTO.seatNumber;
            seat.hallId = seatDTO.seatNumber;
            seat.seatType = seatDTO.seatType;

            var citye = await _dataService.AddSeats(seat);

            return Ok(citye);
        }


        [HttpGet]
        [Route("GetShows")]
        public async Task<ActionResult<List<Seat>>> GetShows(int hallid)
        {

            List<Show> shows = new List<Show>();
            try
            {
                shows = await _dataService.GetShows(hallid);

                return Ok(shows);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }



    }
}
