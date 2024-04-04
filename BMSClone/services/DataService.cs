using BMSClone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BMSClone.services
{
    public class DataService : IDataservice
    {
        private readonly  DbContext dbContext;

        public DataService(DbContext _context)
        { 
            dbContext = _context;
        }
       
        public async Task<List<Movie>> GetMovies()
        {

            List < Movie > list = new List<Movie>();

            try
            {
                list = await dbContext.Set<Movie>().ToListAsync();
              
            }
            catch (Exception ex)
            { 

            }
            return list;
        }

      
        public async Task<Movie> CreateMovie(Movie movie)
        {
            // Add the new movie object to the DbSet<Movie>
            dbContext.Set<Movie>().Add(movie);

            // Save changes to the database
            await dbContext.SaveChangesAsync();
            return movie;
        
        
        }

        public async Task<List<City>> GetCities()
        {
            List<City> cities = new List<City>();

            try
            {
                cities = await dbContext.Set<City>().ToListAsync();
            }
            catch (Exception ex)
            { 
            }
            return cities;
        }

        public async Task<City> AddCity(City city)
        {
            dbContext.Set<City>().Add(city);
            await dbContext.SaveChangesAsync();
            return city;
        }

        public async Task<List<Theatre>> GetTheatres()
        {
            List<Theatre> theatres = new List<Theatre>();

            try
            {
                theatres = await dbContext.Set<Theatre>().ToListAsync();
            }
            catch (Exception ex)
            {
            }
            return theatres;
        }

        public async Task<Theatre> AddTheatre(Theatre theatre)
        {
            dbContext.Set<Theatre>().Add(theatre);
            await dbContext.SaveChangesAsync();
            return theatre;
        }

        public async Task<List<Language>> GetLanguages()
        {
            List<Language> cities = new List<Language>();

            try
            {
                cities = await dbContext.Set<Language>().ToListAsync();
            }
            catch (Exception ex)
            {
            }
            return cities;
        }

        public async Task<Language> AddLanguage(Language city)
        {
            dbContext.Set<Language>().Add(city);
            await dbContext.SaveChangesAsync();
            return city;
        }

        public async Task<List<Hall>> GetHalls(int theatreid)
        {
            List<Hall> halls = new List<Hall>();

            try
            {
                halls = await dbContext.Set<Hall>().Where(x=> x.TheatreId==theatreid).ToListAsync();

            }
            catch (Exception ex)
            {
            }
            return halls;
        }

        public async Task<Hall> AddHalls(Hall hall)
        {
            dbContext.Set<Hall>().Add(hall);
            await dbContext.SaveChangesAsync();
            return hall;
        }

        public async Task<List<Seat>> GetSeats(int hallid)
        {
            List<Seat> seats = new List<Seat>();

            try
            {
                seats = await dbContext.Set<Seat>().Where(x => x.hallId == hallid).ToListAsync();

            }
            catch (Exception ex)
            {
            }
            return seats;
        }

        public async Task<Seat> AddSeats(Seat seat)
        {
            dbContext.Set<Seat>().Add(seat);
            await dbContext.SaveChangesAsync();
            return seat;
        }

        public async Task<List<Show>> GetShows(int hallid)
        {
            List<Show> seats = new List<Show>();
            try
            {
                seats = await dbContext.Set<Show>().Where(x => x.hallid == hallid).ToListAsync();

            }
            catch (Exception ex)
            {
            }
            return seats;
        }

        public async Task<Show> AddShows(Show show)
        {
            dbContext.Set<Show>().Add(show);
            await dbContext.SaveChangesAsync();
            return show;
        }


    }
}
