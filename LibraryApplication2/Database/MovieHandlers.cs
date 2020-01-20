using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2.Database
{
    class MovieHandlers
    {
        private const string MOVIES_COLLECTION = "movies";
        private readonly IMongoDatabase _database;
        public MovieHandlers(string dbName = "library-application2")
        {
            MongoClient dbClient = new MongoClient();
            _database = dbClient.GetDatabase(dbName);
        }
        public void SaveMovieToDB(Movie movie)
        {
            var collection = _database.GetCollection<Movie>(MOVIES_COLLECTION);
            collection.InsertOne(movie);
        }
        public List<Movie> GetMoviesFromDB()
        {
            var collection = _database.GetCollection<Movie>(MOVIES_COLLECTION);
            var movies = collection.Find<Movie>(m => true).ToList();
            return movies;
        }

        public void DeleteMovieById(Movie movie)
        {
            var collection = _database.GetCollection<Movie>(MOVIES_COLLECTION);
            collection.DeleteOne(m => m.Id == movie.Id);
        }
        public void UpdateMovie(Movie movieToUpdate, Movie updatedMovie)
        {
            var collection = _database.GetCollection<Movie>(MOVIES_COLLECTION);
            UpdateDefinition<Movie> update = Builders<Movie>.Update
                .Set(m => m.Name, updatedMovie.Name)
                .Set(m => m.ReleseYear, updatedMovie.ReleseYear)
                .Set(m => m.Genre, updatedMovie.Genre)
                .Set(m => m.Duration, updatedMovie.Duration)
                .Set(m => m.AgeLimit, updatedMovie.AgeLimit);
            collection.UpdateOne(m => m.Id == movieToUpdate.Id, update);
        }
    }
}
