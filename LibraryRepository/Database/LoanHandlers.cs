using LibraryRepository.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Database
{
    class LoanHandlers
    {
        private const string BOOK_LOANS_COLLECTION = "book-loans";
        private const string MOVIE_LOANS_COLLECTION = "movie-loans";
        private readonly IMongoDatabase _database;
        public LoanHandlers(string dbName = "library-application2")
        {
            MongoClient dbClient = new MongoClient();
            _database = dbClient.GetDatabase(dbName);
        }

        public void InsertBook(Loan loan)
        {
            var collection = _database.GetCollection<Loan>(BOOK_LOANS_COLLECTION);
            collection.InsertOne(loan);
        }
        public List<Loan> GetBookLoansById(ObjectId id)
        {
            var collection = _database.GetCollection<Loan>(BOOK_LOANS_COLLECTION);
            var loans = collection.Find<Loan>(l => l.BookArticle.Id == id).ToList();
            return loans;
        }
        public List<Loan> GetBookLoansByMember(Member member)
        {
            var collection = _database.GetCollection<Loan>(BOOK_LOANS_COLLECTION);
            var loans = collection.Find<Loan>(l => l.Member.Id == member.Id).ToList();
            return loans;
        }
        public void ReturnBook(Loan loanToReturn, DateTime returnDate)
        {
            var collection = _database.GetCollection<Loan>(BOOK_LOANS_COLLECTION);
            UpdateDefinition<Loan> update = Builders<Loan>.Update
                .Set(l => l.EndDate, returnDate);
            collection.UpdateOne(l => l.Id == loanToReturn.Id, update);
        }

        public void InsertMovie(Loan loan)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);
            collection.InsertOne(loan);
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
        public void ReturnMovie(Loan loanToReturn, DateTime returnDate)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);

            UpdateDefinition<Loan> update = Builders<Loan>.Update
                .Set(l => l.EndDate, returnDate);
            collection.UpdateOne(l => l.Id == loanToReturn.Id, update);
        }

        

    }
}
