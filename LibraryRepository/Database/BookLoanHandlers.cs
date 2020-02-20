using LibraryRepository.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Database
{
    class BookLoanHandlers
    {
        private const string BOOK_LOANS_COLLECTION = "book-loans";
        private readonly IMongoDatabase _database;
        public BookLoanHandlers(string dbName = "mvc-library-application")
        {
            MongoClient dbClient = new MongoClient();
            _database = dbClient.GetDatabase(dbName);
        }

        internal List<Loan> GetAllBookLoans()
        {
            var collection = _database.GetCollection<Loan>(BOOK_LOANS_COLLECTION);
            return collection.Find(bl => true).ToList();
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

        internal Loan GetBookLoanByBookLoanId(ObjectId bookLoanId)
        {
            var collection = _database.GetCollection<Loan>(BOOK_LOANS_COLLECTION);
            return collection.Find(bl => bl.Id == bookLoanId).First();
        }

        internal void UpdateBookLoan(ObjectId loanId, DateTime startDate, DateTime endDate)
        {
            var collection = _database.GetCollection<Loan>(BOOK_LOANS_COLLECTION);
            UpdateDefinition<Loan> update = Builders<Loan>.Update
                .Set(bl => bl.StartDate, startDate)
                .Set(bl => bl.EndDate, endDate);
            collection.UpdateOne(bl => bl.Id == loanId, update);
        }

        internal void DeleteBookLoan(ObjectId loanId)
        {
            var collection = _database.GetCollection<Loan>(BOOK_LOANS_COLLECTION);
            collection.DeleteOne(bl => bl.Id == loanId);
        }

        public void ReturnBook(Loan loanToReturn, DateTime returnDate)
        {
            var collection = _database.GetCollection<Loan>(BOOK_LOANS_COLLECTION);
            UpdateDefinition<Loan> update = Builders<Loan>.Update
                .Set(l => l.EndDate, returnDate);
            collection.UpdateOne(l => l.Id == loanToReturn.Id, update);
        }
    }
}
