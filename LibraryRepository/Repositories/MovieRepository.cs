using LibraryRepository.Database;
using LibraryRepository.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> GetMovies()
        {
            MovieHandlers mh = new MovieHandlers();
            return mh.GetMoviesFromDB();
        }
        public static void DeleteMovie(Movie movie)
        {
            MovieHandlers mh = new MovieHandlers();
            mh.DeleteMovieById(movie);
        }
        public static void SaveMovieToDB(Movie movie)
        {
            MovieHandlers mh = new MovieHandlers();
            mh.SaveMovieToDB(movie);
        }
        public static void UpdateMovie(Movie movieToUpdate, Movie updatedMovie)
        {
            MovieHandlers mh = new MovieHandlers();
            mh.UpdateMovie(movieToUpdate, updatedMovie);
        }
    }
}
