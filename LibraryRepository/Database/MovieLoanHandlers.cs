using LibraryRepository.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Database
{
    class MovieLoanHandlers
    {
        private const string MOVIE_LOANS_COLLECTION = "movie-loans";
        private readonly IMongoDatabase _database;

        public MovieLoanHandlers(string dbName = "mvc-library-application")
        {
            MongoClient dbClient = new MongoClient();
            _database = dbClient.GetDatabase(dbName);
        }

        public void InsertMovie(Loan loan)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);
            collection.InsertOne(loan);
        }

        internal List<Loan> GetAllMovieLoans()
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);
            return collection.Find(ml => true).ToList();
        }

        public List<Loan> GetMovieLoansById(ObjectId id)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);
            var loans = collection.Find<Loan>(m => m.MovieArticle.Id == id).ToList();
            return loans;
        }
        public List<Loan> GetMovieLoansByMember(Member member)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);
            var loans = collection.Find<Loan>(m => m.Member.Id == member.Id).ToList();
            return loans;
        }

        internal Loan GetAllMovieLoanByMovieLoanId(ObjectId movieloanId)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);
            return collection.Find(ml => ml.Id == movieloanId).First();
        }

        internal void UpdateMovieLoan(ObjectId loanId, DateTime startDate, DateTime endDate)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);
            UpdateDefinition<Loan> update = Builders<Loan>.Update
                .Set(m => m.StartDate, startDate)
                .Set(m => m.EndDate, endDate);
            collection.UpdateOne(ml => ml.Id == loanId, update);
        }

        internal Loan GetMovieLoanByMovieLoanId(ObjectId movieLoanId)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);
            return collection.Find(ml => ml.Id == movieLoanId).First();
        }

        internal void DeleteMovieLoan(ObjectId loanId)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);
            collection.DeleteOne(ml => ml.Id == loanId);
        }

        public void ReturnMovie(Loan loanToReturn, DateTime returnDate)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);

            UpdateDefinition<Loan> update = Builders<Loan>.Update
                .Set(l => l.EndDate, returnDate);
            collection.UpdateOne(l => l.Id == loanToReturn.Id, update);
        }
    }
}
