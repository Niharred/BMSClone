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
        public List<Movie> GetAllMovies()
        {
            return _dataService.GetMovies();
            
        }
    }
}
