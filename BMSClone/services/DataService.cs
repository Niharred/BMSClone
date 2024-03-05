using BMSClone.Models;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.services
{
    public class DataService : IDataservice
    {
        private readonly  DbContext dbContext;

        public DataService(DbContext _context)
        { 
            dbContext = _context;
        }

        public List<Movie> GetMovies()
        {
            List<Movie> list = dbContext.Set<Movie>().ToList();
            return list;

        }



    }
}
