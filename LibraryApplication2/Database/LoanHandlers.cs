using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2.Database
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
        public void ReturnMovie(Loan loanToReturn, DateTime returnDate)
        {
            var collection = _database.GetCollection<Loan>(MOVIE_LOANS_COLLECTION);

            UpdateDefinition<Loan> update = Builders<Loan>.Update
                .Set(l => l.EndDate, returnDate);
            collection.UpdateOne(l => l.Id == loanToReturn.Id, update);
        }

        public int CheckBookLoansToCopies(ObjectId bookId, int numberOfCopies, DateTime date)
        {
            List<Loan> loans = GetBookLoansById(bookId);

            foreach (Loan loan in loans)
            {
                int checkStartDate = Validations.CompareDates(date, loan.StartDate);
                int checkEndDate = Validations.CompareDates(date, loan.EndDate);

                if (checkStartDate >= 0 && checkEndDate <= 0)
                {
                    numberOfCopies -= 1;
                }
                else if (true)
                {
                    DateTime endDate = date.AddMonths(3);
                    checkStartDate = Validations.CompareDates(endDate, loan.StartDate);
                    checkEndDate = Validations.CompareDates(endDate, loan.EndDate);

                    if (checkStartDate >= 0 && checkEndDate <= 0)
                    {
                        numberOfCopies -= 1;
                    }
                }
            }
            return numberOfCopies;
        }

        public int CheckMovieLoansToCopies(ObjectId id, int numberOfCopies, DateTime date)
        {

            List<Loan> loans = GetMovieLoansById(id);
            foreach (Loan loan in loans)
            {
                int checkStartDate = Validations.CompareDates(date, loan.StartDate);
                int checkEndDate = Validations.CompareDates(date, loan.EndDate);

                if (checkStartDate >= 0 && checkEndDate <= 0)
                {
                    numberOfCopies -= 1;
                }
                else if (true)
                {
                    DateTime endDate = date.AddMonths(3);
                    checkStartDate = Validations.CompareDates(endDate, loan.StartDate);
                    checkEndDate = Validations.CompareDates(endDate, loan.EndDate);

                    if (checkStartDate >= 0 && checkEndDate <= 0)
                    {
                        numberOfCopies -= 1;
                    }
                }
            }
            return numberOfCopies;
        }

    }
}
