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
        public static void DeleteMovie(ObjectId movieId)
        {
            MovieHandlers mh = new MovieHandlers();
            mh.DeleteMovieById(movieId);
        }
        public static void SaveMovieToDB(Movie movie)
        {
            MovieHandlers mh = new MovieHandlers();
            mh.SaveMovieToDB(movie);
        }

        public static Movie GetMovieById(ObjectId movieId)
        {
            MovieHandlers mh = new MovieHandlers();
            return mh.GetMovieByIdFromDB(movieId);
        }

        public static void UpdateMovie(ObjectId movieToUpdateId, Movie updatedMovie)
        {
            MovieHandlers mh = new MovieHandlers();
            mh.UpdateMovie(movieToUpdateId, updatedMovie);
        }
    }
}
