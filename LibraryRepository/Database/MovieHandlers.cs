using LibraryRepository.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Database
{
    class MovieHandlers
    {
        private const string MOVIES_COLLECTION = "movies";
        private readonly IMongoDatabase _database;
        public MovieHandlers(string dbName = "mvc-library-application")
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

        internal Movie GetMovieByIdFromDB(ObjectId movieId)
        {
            var collection = _database.GetCollection<Movie>(MOVIES_COLLECTION);
            return collection.Find(m => m.Id == movieId).First();
        }

        public void DeleteMovieById(ObjectId movieId)
        {
            var collection = _database.GetCollection<Movie>(MOVIES_COLLECTION);
            collection.DeleteOne(m => m.Id == movieId);
        }
        public void UpdateMovie(ObjectId movieToUpdateId, Movie updatedMovie)
        {
            var collection = _database.GetCollection<Movie>(MOVIES_COLLECTION);
            UpdateDefinition<Movie> update = Builders<Movie>.Update
                .Set(m => m.Name, updatedMovie.Name)
                .Set(m => m.ReleseYear, updatedMovie.ReleseYear)
                .Set(m => m.Genre, updatedMovie.Genre)
                .Set(m => m.Duration, updatedMovie.Duration)
                .Set(m => m.AgeLimit, updatedMovie.AgeLimit);
            collection.UpdateOne(m => m.Id == movieToUpdateId, update);
        }
    }
}
