using BMSClone.Models;

namespace BMSClone.services
{
    public interface IDataservice
    {
        Task<List<Movie>> GetMovies();

        Task<Movie> CreateMovie(Movie movie);

        Task<City> AddCity(City city);

        Task<List<City>> GetCities();

        Task<Theatre> AddTheatre(Theatre theatre);

        Task<List<Theatre>> GetTheatres();

        Task<Language> AddLanguage(Language city);

        Task<List<Language>> GetLanguages();

        Task<List<Hall>> GetHalls(int theatreid);

        Task<Hall> AddHalls(Hall hall);

        Task<List<Seat>> GetSeats(int hallid);

        Task<Seat> AddSeats(Seat seat);

        Task<List<Show>> GetShows(int hallid);

        Task<int> AddShows(Show show);

        Task<List<Seat>> GetSeatsByHallId(int hallId);

        Task<ShowSeats> AddShowSeats(int seatId, int showId);

        Task<List<Movie>> GetMoviesByCityId(int id);
    }
}
